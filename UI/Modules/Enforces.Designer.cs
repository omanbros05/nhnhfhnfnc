namespace Maleos.Modules
{
    partial class Enforces
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.header1 = new Maleos.Controls.Header();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemSpotCheck = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSpotHandelDesision = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemForceMeasureDecisionApprove = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemForceMeasureDecision = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemOrderDeadlineReform = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSpotHandelDesisionSixtyDay = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemReformReView = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemReviewOptionApprove = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemSpotShoot = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemHearingNotice = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemPutDown = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemHearingInform = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemWritServiceReceipt = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemEnquireQuestion = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(982, 75);
            this.header1.TabIndex = 1;
            this.header1.Title = "台州市安监移动执法系统";
            this.header1.BackEvent += new System.EventHandler(this.header1_BackEvent);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 75);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Padding = new System.Windows.Forms.Padding(17, 0, 17, 15);
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(982, 476);
            this.splitContainerControl1.SplitterPosition = 220;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemSpotCheck,
            this.navBarItemSpotHandelDesision,
            this.navBarItemForceMeasureDecisionApprove,
            this.navBarItemForceMeasureDecision,
            this.navBarItemOrderDeadlineReform,
            this.navBarItemSpotHandelDesisionSixtyDay,
            this.navBarItemReformReView,
            this.navBarItemReviewOptionApprove,
            this.navBarItemHearingNotice,
            this.navBarItemPutDown,
            this.navBarItemHearingInform,
            this.navBarItemWritServiceReceipt,
            this.navBarItemEnquireQuestion,
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItemSpotShoot});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 220;
            this.navBarControl1.Size = new System.Drawing.Size(220, 461);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "案件移送";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "现场检查";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSpotCheck),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSpotHandelDesision),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemForceMeasureDecisionApprove),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemForceMeasureDecision),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemOrderDeadlineReform),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSpotHandelDesisionSixtyDay)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemSpotCheck
            // 
            this.navBarItemSpotCheck.Caption = "现场检查记录";
            this.navBarItemSpotCheck.Name = "navBarItemSpotCheck";
            this.navBarItemSpotCheck.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSpotCheck_LinkClicked);
            // 
            // navBarItemSpotHandelDesision
            // 
            this.navBarItemSpotHandelDesision.Caption = "现场处理措施决定书";
            this.navBarItemSpotHandelDesision.Name = "navBarItemSpotHandelDesision";
            this.navBarItemSpotHandelDesision.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSpotHandelDesision_LinkClicked);
            // 
            // navBarItemForceMeasureDecisionApprove
            // 
            this.navBarItemForceMeasureDecisionApprove.Caption = "强制措施决定审批表（15日内）";
            this.navBarItemForceMeasureDecisionApprove.Name = "navBarItemForceMeasureDecisionApprove";
            this.navBarItemForceMeasureDecisionApprove.Visible = false;
            this.navBarItemForceMeasureDecisionApprove.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemForceMeasureDecisionApprove_LinkClicked);
            // 
            // navBarItemForceMeasureDecision
            // 
            this.navBarItemForceMeasureDecision.Caption = "强制措施决定书（15日内）";
            this.navBarItemForceMeasureDecision.Name = "navBarItemForceMeasureDecision";
            this.navBarItemForceMeasureDecision.Visible = false;
            this.navBarItemForceMeasureDecision.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemForceMeasureDecision_LinkClicked);
            // 
            // navBarItemOrderDeadlineReform
            // 
            this.navBarItemOrderDeadlineReform.Caption = "责令限期整改指令书";
            this.navBarItemOrderDeadlineReform.Name = "navBarItemOrderDeadlineReform";
            this.navBarItemOrderDeadlineReform.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemOrderDeadlineReform_LinkClicked);
            // 
            // navBarItemSpotHandelDesisionSixtyDay
            // 
            this.navBarItemSpotHandelDesisionSixtyDay.Caption = "现场处理措施决定书（6个月内）";
            this.navBarItemSpotHandelDesisionSixtyDay.Name = "navBarItemSpotHandelDesisionSixtyDay";
            this.navBarItemSpotHandelDesisionSixtyDay.Visible = false;
            this.navBarItemSpotHandelDesisionSixtyDay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSpotHandelDesisionSixtyDay_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "整改复查";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemReformReView),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemReviewOptionApprove)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemReformReView
            // 
            this.navBarItemReformReView.Caption = "整改复查意见书";
            this.navBarItemReformReView.Name = "navBarItemReformReView";
            this.navBarItemReformReView.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemReformReView_LinkClicked);
            // 
            // navBarItemReviewOptionApprove
            // 
            this.navBarItemReviewOptionApprove.Caption = "复查意见审批表";
            this.navBarItemReviewOptionApprove.Name = "navBarItemReviewOptionApprove";
            this.navBarItemReviewOptionApprove.Visible = false;
            this.navBarItemReviewOptionApprove.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemReviewOptionApprove_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "现场取证";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSpotShoot)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItemSpotShoot
            // 
            this.navBarItemSpotShoot.Caption = "现场取照";
            this.navBarItemSpotShoot.Name = "navBarItemSpotShoot";
            this.navBarItemSpotShoot.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSpotShoot_LinkClicked);
            // 
            // navBarItemHearingNotice
            // 
            this.navBarItemHearingNotice.Name = "navBarItemHearingNotice";
            // 
            // navBarItemPutDown
            // 
            this.navBarItemPutDown.Name = "navBarItemPutDown";
            // 
            // navBarItemHearingInform
            // 
            this.navBarItemHearingInform.Name = "navBarItemHearingInform";
            // 
            // navBarItemWritServiceReceipt
            // 
            this.navBarItemWritServiceReceipt.Name = "navBarItemWritServiceReceipt";
            // 
            // navBarItemEnquireQuestion
            // 
            this.navBarItemEnquireQuestion.Name = "navBarItemEnquireQuestion";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "案件移送审批表";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkPressed);
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "案件移送书";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // Enforces
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.header1);
            this.Name = "Enforces";
            this.Size = new System.Drawing.Size(982, 551);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Header header1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSpotCheck;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSpotHandelDesision;
        private DevExpress.XtraNavBar.NavBarItem navBarItemForceMeasureDecisionApprove;
        private DevExpress.XtraNavBar.NavBarItem navBarItemForceMeasureDecision;
        private DevExpress.XtraNavBar.NavBarItem navBarItemOrderDeadlineReform;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSpotHandelDesisionSixtyDay;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemReformReView;
        private DevExpress.XtraNavBar.NavBarItem navBarItemReviewOptionApprove;
        private DevExpress.XtraNavBar.NavBarItem navBarItemHearingNotice;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPutDown;
        private DevExpress.XtraNavBar.NavBarItem navBarItemHearingInform;
        private DevExpress.XtraNavBar.NavBarItem navBarItemWritServiceReceipt;
        private DevExpress.XtraNavBar.NavBarItem navBarItemEnquireQuestion;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSpotShoot;
    }
}
