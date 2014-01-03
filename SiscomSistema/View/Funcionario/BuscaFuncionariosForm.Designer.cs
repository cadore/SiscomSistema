namespace SiscomSistema.View.Funcionario
{
    partial class BuscaFuncionariosForm
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalario_fixo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladministrador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacesso_inativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.tfValor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoPesquisa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, 76);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(902, 319);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Siscom.Entities.Funcionarios);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome,
            this.colsenha,
            this.colsalario_fixo,
            this.colcomissao,
            this.colvendas,
            this.coladministrador,
            this.colacesso_inativo,
            this.colinativo});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colid
            // 
            this.colid.Caption = "COD.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 49;
            // 
            // colnome
            // 
            this.colnome.Caption = "NOME";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.OptionsColumn.AllowEdit = false;
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            this.colnome.Width = 343;
            // 
            // colsenha
            // 
            this.colsenha.FieldName = "senha";
            this.colsenha.Name = "colsenha";
            this.colsenha.OptionsColumn.AllowEdit = false;
            // 
            // colsalario_fixo
            // 
            this.colsalario_fixo.FieldName = "salario_fixo";
            this.colsalario_fixo.Name = "colsalario_fixo";
            this.colsalario_fixo.OptionsColumn.AllowEdit = false;
            // 
            // colcomissao
            // 
            this.colcomissao.Caption = "COMISSÃO";
            this.colcomissao.FieldName = "comissao";
            this.colcomissao.Name = "colcomissao";
            this.colcomissao.OptionsColumn.AllowEdit = false;
            this.colcomissao.Visible = true;
            this.colcomissao.VisibleIndex = 2;
            this.colcomissao.Width = 107;
            // 
            // colvendas
            // 
            this.colvendas.Caption = "VENDAS";
            this.colvendas.FieldName = "vendas";
            this.colvendas.Name = "colvendas";
            this.colvendas.OptionsColumn.AllowEdit = false;
            this.colvendas.Visible = true;
            this.colvendas.VisibleIndex = 3;
            this.colvendas.Width = 69;
            // 
            // coladministrador
            // 
            this.coladministrador.Caption = "ADMINISTRADOR";
            this.coladministrador.FieldName = "administrador";
            this.coladministrador.Name = "coladministrador";
            this.coladministrador.OptionsColumn.AllowEdit = false;
            this.coladministrador.Visible = true;
            this.coladministrador.VisibleIndex = 4;
            this.coladministrador.Width = 113;
            // 
            // colacesso_inativo
            // 
            this.colacesso_inativo.Caption = "ACESSO INATIVO";
            this.colacesso_inativo.FieldName = "acesso_inativo";
            this.colacesso_inativo.Name = "colacesso_inativo";
            this.colacesso_inativo.OptionsColumn.AllowEdit = false;
            this.colacesso_inativo.Visible = true;
            this.colacesso_inativo.VisibleIndex = 5;
            this.colacesso_inativo.Width = 107;
            // 
            // colinativo
            // 
            this.colinativo.Caption = "INATIVO";
            this.colinativo.FieldName = "inativo";
            this.colinativo.Name = "colinativo";
            this.colinativo.OptionsColumn.AllowEdit = false;
            this.colinativo.Visible = true;
            this.colinativo.VisibleIndex = 6;
            this.colinativo.Width = 96;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBuscar);
            this.panelControl1.Controls.Add(this.tfValor);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbTipoPesquisa);
            this.panelControl1.Location = new System.Drawing.Point(12, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(728, 59);
            this.panelControl1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(426, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tfValor
            // 
            this.tfValor.Location = new System.Drawing.Point(5, 31);
            this.tfValor.Name = "tfValor";
            this.tfValor.Size = new System.Drawing.Size(415, 20);
            this.tfValor.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Buscar por:";
            // 
            // cbTipoPesquisa
            // 
            this.cbTipoPesquisa.EditValue = "NOME";
            this.cbTipoPesquisa.Location = new System.Drawing.Point(66, 5);
            this.cbTipoPesquisa.Name = "cbTipoPesquisa";
            this.cbTipoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoPesquisa.Properties.Items.AddRange(new object[] {
            "CODIGO",
            "NOME"});
            this.cbTipoPesquisa.Size = new System.Drawing.Size(108, 20);
            this.cbTipoPesquisa.TabIndex = 0;
            this.cbTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPesquisa_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSair);
            this.panelControl2.Controls.Add(this.btnNovo);
            this.panelControl2.Location = new System.Drawing.Point(746, 11);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(168, 59);
            this.panelControl2.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(86, 18);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(5, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // BuscaFuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 407);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl);
            this.Name = "BuscaFuncionariosForm";
            this.Text = "Busca Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoPesquisa;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit tfValor;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSair;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colsenha;
        private DevExpress.XtraGrid.Columns.GridColumn colsalario_fixo;
        private DevExpress.XtraGrid.Columns.GridColumn colcomissao;
        private DevExpress.XtraGrid.Columns.GridColumn colvendas;
        private DevExpress.XtraGrid.Columns.GridColumn coladministrador;
        private DevExpress.XtraGrid.Columns.GridColumn colacesso_inativo;
        private DevExpress.XtraGrid.Columns.GridColumn colinativo;
    }
}