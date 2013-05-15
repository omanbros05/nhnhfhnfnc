using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnforceUI
{
    public class TaskService
    {
        private static TaskService instance = null;
        public static TaskService Instance
        {
            get 
            {
                if (instance == null)
                    instance = new TaskService();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public delegate void AddItemEventHandeler(string key, FormState formState);
        public event AddItemEventHandeler AddItemEvent;
        protected void AddItem(string key, FormState formState)
        {
            lock (this)
            {
                if(AddItemEvent != null)
                    AddItemEvent(key, formState);
            }
        }

        public delegate void RemoveItemEventHandeler(string key,FormState formState);
        public event RemoveItemEventHandeler RemoveItemEvent;
        public void RemoveItem(string key, FormState formState)
        {
            lock (this)
            {
                if (RemoveItemEvent != null)
                    RemoveItemEvent(key, formState);
            }
        }

        private static Dictionary<string, FormState> FormStateCache = new Dictionary<string, FormState>();
        /// <summary>
        /// 清除缓存
        /// </summary>
        public void ClearCache()
        {
            FormStateCache.Clear();
        }

        public void Add(BaseForm form)
        {
            Add(form, null);
        }

        public void Add(BaseForm form,BaseForm parentForm)
        {
            FormItem formItem = new FormItem{ FormControl = form};
            FormItem parentFormItem = null;
            if (parentForm != null)
                parentFormItem = new FormItem { FormControl = parentForm, CurrentPage = parentForm.GetCurrentPage(), FormControls = parentForm.GetTableControls()};

            FormState formState = new FormState { CurrentForm = formItem, ParentForm = parentFormItem};
            Add(form.GUID, formState);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="key"></param>
        /// <param name="formState"></param>
        private void Add(string key, FormState formState)
        {
            FormStateCache.Add(key, formState);
            if (AddItemEvent != null)
                AddItemEvent(key, formState);
        }

        /// <summary>
        /// 获取窗体项
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public FormState GetItem(string key)
        {
            if (FormStateCache.ContainsKey(key))
                return FormStateCache[key];
            else
                throw new Exception("窗体不存在！");
        }

        /// <summary>
        /// 删除窗体状态
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            if (FormStateCache.ContainsKey(key))
            {
                if (RemoveItemEvent != null)
                    RemoveItemEvent(key, FormStateCache[key]);
                FormStateCache.Remove(key);
            }
        }
    }
}
