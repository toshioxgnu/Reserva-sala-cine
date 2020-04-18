namespace ReservaSalaCine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAsientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAsientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderAsientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarSalaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // consultarSalaToolStripMenuItem
            // 
            this.consultarSalaToolStripMenuItem.Name = "consultarSalaToolStripMenuItem";
            resources.ApplyResources(this.consultarSalaToolStripMenuItem, "consultarSalaToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAsientoToolStripMenuItem,
            this.verAsientosToolStripMenuItem,
            this.venderAsientoToolStripMenuItem});
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            resources.ApplyResources(this.salaToolStripMenuItem, "salaToolStripMenuItem");
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // agregarAsientoToolStripMenuItem
            // 
            this.agregarAsientoToolStripMenuItem.Name = "agregarAsientoToolStripMenuItem";
            resources.ApplyResources(this.agregarAsientoToolStripMenuItem, "agregarAsientoToolStripMenuItem");
            // 
            // verAsientosToolStripMenuItem
            // 
            this.verAsientosToolStripMenuItem.Name = "verAsientosToolStripMenuItem";
            resources.ApplyResources(this.verAsientosToolStripMenuItem, "verAsientosToolStripMenuItem");
            // 
            // venderAsientoToolStripMenuItem
            // 
            this.venderAsientoToolStripMenuItem.Name = "venderAsientoToolStripMenuItem";
            resources.ApplyResources(this.venderAsientoToolStripMenuItem, "venderAsientoToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarSalaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAsientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAsientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderAsientoToolStripMenuItem;
    }
}

