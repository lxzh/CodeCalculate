﻿namespace CodeCalculate
{
    partial class LoadButton
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
            this.components = new System.ComponentModel.Container();
            this.timLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timLoad
            // 
            this.timLoad.Enabled = true;
            this.timLoad.Interval = 300;
            this.timLoad.Tick += new System.EventHandler(this.timLoad_Tick);
            // 
            // LoadButton
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextChanged += new System.EventHandler(this.LoadButton_TextChanged);
            this.Validated += new System.EventHandler(this.LoadButton_Validated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timLoad;
    }
}
