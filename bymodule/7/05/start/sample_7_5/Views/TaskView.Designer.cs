﻿namespace sample_7_5.Views {
  partial class TaskView {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.SubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.ItemForSubject = new DevExpress.XtraLayout.LayoutControlItem();
      this.DueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
      this.ItemForDueDate = new DevExpress.XtraLayout.LayoutControlItem();
      this.taskViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.taskViewModelBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataLayoutControl1
      // 
      this.dataLayoutControl1.Controls.Add(this.SubjectTextEdit);
      this.dataLayoutControl1.Controls.Add(this.DueDateDateEdit);
      this.dataLayoutControl1.DataSource = this.taskViewModelBindingSource;
      this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.Root;
      this.dataLayoutControl1.Size = new System.Drawing.Size(575, 358);
      this.dataLayoutControl1.TabIndex = 0;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(575, 358);
      this.Root.TextVisible = false;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.AllowDrawBackground = false;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSubject,
            this.ItemForDueDate});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "autoGeneratedGroup0";
      this.layoutControlGroup1.Size = new System.Drawing.Size(555, 338);
      // 
      // SubjectTextEdit
      // 
      this.SubjectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taskViewModelBindingSource, "Subject", true));
      this.SubjectTextEdit.Location = new System.Drawing.Point(69, 12);
      this.SubjectTextEdit.Name = "SubjectTextEdit";
      this.SubjectTextEdit.Size = new System.Drawing.Size(494, 20);
      this.SubjectTextEdit.StyleController = this.dataLayoutControl1;
      this.SubjectTextEdit.TabIndex = 4;
      // 
      // ItemForSubject
      // 
      this.ItemForSubject.Control = this.SubjectTextEdit;
      this.ItemForSubject.Location = new System.Drawing.Point(0, 0);
      this.ItemForSubject.Name = "ItemForSubject";
      this.ItemForSubject.Size = new System.Drawing.Size(555, 24);
      this.ItemForSubject.Text = "Subject";
      this.ItemForSubject.TextSize = new System.Drawing.Size(45, 13);
      // 
      // DueDateDateEdit
      // 
      this.DueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taskViewModelBindingSource, "DueDate", true));
      this.DueDateDateEdit.EditValue = null;
      this.DueDateDateEdit.Location = new System.Drawing.Point(69, 36);
      this.DueDateDateEdit.Name = "DueDateDateEdit";
      this.DueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DueDateDateEdit.Size = new System.Drawing.Size(494, 20);
      this.DueDateDateEdit.StyleController = this.dataLayoutControl1;
      this.DueDateDateEdit.TabIndex = 5;
      // 
      // ItemForDueDate
      // 
      this.ItemForDueDate.Control = this.DueDateDateEdit;
      this.ItemForDueDate.Location = new System.Drawing.Point(0, 24);
      this.ItemForDueDate.Name = "ItemForDueDate";
      this.ItemForDueDate.Size = new System.Drawing.Size(555, 314);
      this.ItemForDueDate.Text = "Due Date";
      this.ItemForDueDate.TextSize = new System.Drawing.Size(45, 13);
      // 
      // taskViewModelBindingSource
      // 
      this.taskViewModelBindingSource.DataSource = typeof(sample_7_5.ViewModels.TaskViewModel);
      // 
      // mvvmContext1
      // 
      this.mvvmContext1.ContainerControl = this;
      this.mvvmContext1.ViewModelType = typeof(sample_7_5.ViewModels.TaskViewModel);
      // 
      // TaskView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataLayoutControl1);
      this.Name = "TaskView";
      this.Size = new System.Drawing.Size(575, 358);
      this.Load += new System.EventHandler(this.TaskView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.taskViewModelBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
      this.ResumeLayout(false);

    }
    #endregion

    private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraEditors.TextEdit SubjectTextEdit;
    private System.Windows.Forms.BindingSource taskViewModelBindingSource;
    private DevExpress.XtraEditors.DateEdit DueDateDateEdit;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem ItemForSubject;
    private DevExpress.XtraLayout.LayoutControlItem ItemForDueDate;
  }
}