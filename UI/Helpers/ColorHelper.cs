﻿using System;
using System.Linq;
using System.Drawing;
using DevExpress.XtraBars;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Maleos.Helpers
{
    public class ColorHelper
    {
        public static Form MainForm = null;
        public static Color LabelColor = Color.White;
        public static Color LabelColorLight = Color.FromArgb(201, 201, 201);
        public static Color LabelColorDark = Color.FromArgb(179, 179, 179);
        public static Color LabelColorDarkDark = Color.FromArgb(139, 139, 139);
        static void SetMenuManager(Control.ControlCollection controls, BarManager manager)
        {
            foreach (Control ctrl in controls)
            {
                BaseEdit edit = ctrl as BaseEdit;
                if (edit != null)
                    edit.MenuManager = manager;
                if (ctrl.Controls.Count > 0)
                    SetMenuManager(ctrl.Controls, manager);
            }
        }
        public static void SetMenuManager(Control.ControlCollection controls, string key, Form form)
        {
            BarManager menuManager = new BarManager();
            menuManager.Form = form;
            BarAndDockingController controller = new BarAndDockingController();
            controller.LookAndFeel.UseDefaultLookAndFeel = false;
            controller.LookAndFeel.SetSkinStyle(key);
            menuManager.Controller = controller;
            SetMenuManager(controls, menuManager);
        }
    }
}
