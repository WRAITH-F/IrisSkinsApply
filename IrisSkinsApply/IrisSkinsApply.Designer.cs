namespace IrisSkinsApply
{
    partial class IrisSkinsApply
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SkinsChange = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinsChangeSub = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine
            // 
            this.skinEngine.@__DrawButtonFocusRectangle = true;
            this.skinEngine.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkinsChange});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(785, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // SkinsChange
            // 
            this.SkinsChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkinsChangeSub});
            this.SkinsChange.Name = "SkinsChange";
            this.SkinsChange.Size = new System.Drawing.Size(68, 21);
            this.SkinsChange.Text = "IrisSkins";
            // 
            // SkinsChangeSub
            // 
            this.SkinsChangeSub.Name = "SkinsChangeSub";
            this.SkinsChangeSub.Size = new System.Drawing.Size(152, 22);
            this.SkinsChangeSub.Text = "皮肤切换";
            // 
            // IrisSkinsApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 491);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "IrisSkinsApply";
            this.Text = "IrisSkinsApply";
            this.Load += new System.EventHandler(this.IrisSkinsApply_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SkinsChange;
        private System.Windows.Forms.ToolStripMenuItem SkinsChangeSub;
    }
}

