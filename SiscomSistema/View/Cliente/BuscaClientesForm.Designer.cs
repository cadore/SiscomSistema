namespace SiscomSistema.View
{
    partial class BuscaClientesForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cbTipoDocumento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.tfDocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_de_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisento_ICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail_principal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail_secundario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacoes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colddd_telefone_fixo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefone_fixo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colddd_telefone_celular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefone_celular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collimite_de_credito = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.gridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1050, 478);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.cbTipoDocumento);
            this.panelControl3.Controls.Add(this.btnPesquisar);
            this.panelControl3.Controls.Add(this.tfDocumento);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(853, 54);
            this.panelControl3.TabIndex = 2;
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.EditValue = "NOME";
            this.cbTipoDocumento.Location = new System.Drawing.Point(80, 2);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoDocumento.Properties.Items.AddRange(new object[] {
            "NOME",
            "CNPJ",
            "CPF"});
            this.cbTipoDocumento.Size = new System.Drawing.Size(77, 20);
            this.cbTipoDocumento.TabIndex = 6;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cb_Tipo_Documento_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(412, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tfDocumento
            // 
            this.tfDocumento.Location = new System.Drawing.Point(5, 27);
            this.tfDocumento.Name = "tfDocumento";
            this.tfDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfDocumento.Size = new System.Drawing.Size(401, 20);
            this.tfDocumento.TabIndex = 4;
            this.tfDocumento.Enter += new System.EventHandler(this.tfDocumento_FocusEnter);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Pesquisar por:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSair);
            this.panelControl2.Controls.Add(this.btnNovo);
            this.panelControl2.Location = new System.Drawing.Point(871, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(167, 54);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(86, 16);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(5, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(2, 72);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1046, 404);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Siscom.Entities.Clientes);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome,
            this.coltipo_de_documento,
            this.coldocumento,
            this.colie,
            this.colisento_ICMS,
            this.colemail_principal,
            this.colemail_secundario,
            this.colendereco,
            this.colnumero,
            this.colcomplemento,
            this.colbairro,
            this.colcidade,
            this.colobservacoes,
            this.colddd_telefone_fixo,
            this.coltelefone_fixo,
            this.colddd_telefone_celular,
            this.coltelefone_celular,
            this.colinativo,
            this.collimite_de_credito});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid, DevExpress.Data.ColumnSortOrder.Descending)});
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
            this.colid.Width = 62;
            // 
            // colnome
            // 
            this.colnome.Caption = "NOME COMPLETO";
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.OptionsColumn.AllowEdit = false;
            this.colnome.OptionsColumn.ReadOnly = true;
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            this.colnome.Width = 520;
            // 
            // coltipo_de_documento
            // 
            this.coltipo_de_documento.FieldName = "tipo_de_documento";
            this.coltipo_de_documento.Name = "coltipo_de_documento";
            this.coltipo_de_documento.OptionsColumn.AllowEdit = false;
            // 
            // coldocumento
            // 
            this.coldocumento.Caption = "DOCUMENTO";
            this.coldocumento.FieldName = "documento";
            this.coldocumento.Name = "coldocumento";
            this.coldocumento.OptionsColumn.AllowEdit = false;
            this.coldocumento.OptionsColumn.ReadOnly = true;
            this.coldocumento.Visible = true;
            this.coldocumento.VisibleIndex = 2;
            this.coldocumento.Width = 200;
            // 
            // colie
            // 
            this.colie.FieldName = "ie";
            this.colie.Name = "colie";
            this.colie.OptionsColumn.AllowEdit = false;
            // 
            // colisento_ICMS
            // 
            this.colisento_ICMS.FieldName = "isento_ICMS";
            this.colisento_ICMS.Name = "colisento_ICMS";
            this.colisento_ICMS.OptionsColumn.AllowEdit = false;
            // 
            // colemail_principal
            // 
            this.colemail_principal.FieldName = "email_principal";
            this.colemail_principal.Name = "colemail_principal";
            this.colemail_principal.OptionsColumn.AllowEdit = false;
            // 
            // colemail_secundario
            // 
            this.colemail_secundario.FieldName = "email_secundario";
            this.colemail_secundario.Name = "colemail_secundario";
            this.colemail_secundario.OptionsColumn.AllowEdit = false;
            // 
            // colendereco
            // 
            this.colendereco.FieldName = "endereco";
            this.colendereco.Name = "colendereco";
            this.colendereco.OptionsColumn.AllowEdit = false;
            // 
            // colnumero
            // 
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.OptionsColumn.AllowEdit = false;
            // 
            // colcomplemento
            // 
            this.colcomplemento.FieldName = "complemento";
            this.colcomplemento.Name = "colcomplemento";
            this.colcomplemento.OptionsColumn.AllowEdit = false;
            // 
            // colbairro
            // 
            this.colbairro.FieldName = "bairro";
            this.colbairro.Name = "colbairro";
            this.colbairro.OptionsColumn.AllowEdit = false;
            // 
            // colcidade
            // 
            this.colcidade.FieldName = "cidade";
            this.colcidade.Name = "colcidade";
            this.colcidade.OptionsColumn.AllowEdit = false;
            // 
            // colobservacoes
            // 
            this.colobservacoes.FieldName = "observacoes";
            this.colobservacoes.Name = "colobservacoes";
            this.colobservacoes.OptionsColumn.AllowEdit = false;
            // 
            // colddd_telefone_fixo
            // 
            this.colddd_telefone_fixo.Caption = "DDD";
            this.colddd_telefone_fixo.FieldName = "ddd_telefone_fixo";
            this.colddd_telefone_fixo.Name = "colddd_telefone_fixo";
            this.colddd_telefone_fixo.OptionsColumn.AllowEdit = false;
            this.colddd_telefone_fixo.Width = 44;
            // 
            // coltelefone_fixo
            // 
            this.coltelefone_fixo.Caption = "TELEFONE FIXO";
            this.coltelefone_fixo.FieldName = "telefone_fixo";
            this.coltelefone_fixo.Name = "coltelefone_fixo";
            this.coltelefone_fixo.OptionsColumn.AllowEdit = false;
            this.coltelefone_fixo.OptionsColumn.ReadOnly = true;
            this.coltelefone_fixo.Visible = true;
            this.coltelefone_fixo.VisibleIndex = 3;
            this.coltelefone_fixo.Width = 151;
            // 
            // colddd_telefone_celular
            // 
            this.colddd_telefone_celular.FieldName = "ddd_telefone_celular";
            this.colddd_telefone_celular.Name = "colddd_telefone_celular";
            this.colddd_telefone_celular.OptionsColumn.AllowEdit = false;
            // 
            // coltelefone_celular
            // 
            this.coltelefone_celular.FieldName = "telefone_celular";
            this.coltelefone_celular.Name = "coltelefone_celular";
            this.coltelefone_celular.OptionsColumn.AllowEdit = false;
            // 
            // colinativo
            // 
            this.colinativo.Caption = "INATIVO";
            this.colinativo.FieldName = "inativo";
            this.colinativo.Name = "colinativo";
            this.colinativo.OptionsColumn.AllowEdit = false;
            this.colinativo.OptionsColumn.ReadOnly = true;
            this.colinativo.Visible = true;
            this.colinativo.VisibleIndex = 4;
            this.colinativo.Width = 95;
            // 
            // collimite_de_credito
            // 
            this.collimite_de_credito.FieldName = "limite_de_credito";
            this.collimite_de_credito.Name = "collimite_de_credito";
            this.collimite_de_credito.OptionsColumn.AllowEdit = false;
            // 
            // BuscaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 478);
            this.Controls.Add(this.panelControl1);
            this.Name = "BuscaClientesForm";
            this.Text = "BuscaClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_de_documento;
        private DevExpress.XtraGrid.Columns.GridColumn coldocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colie;
        private DevExpress.XtraGrid.Columns.GridColumn colisento_ICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colemail_principal;
        private DevExpress.XtraGrid.Columns.GridColumn colemail_secundario;
        private DevExpress.XtraGrid.Columns.GridColumn colendereco;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colcomplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colbairro;
        private DevExpress.XtraGrid.Columns.GridColumn colcidade;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacoes;
        private DevExpress.XtraGrid.Columns.GridColumn colddd_telefone_fixo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefone_fixo;
        private DevExpress.XtraGrid.Columns.GridColumn colddd_telefone_celular;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefone_celular;
        private DevExpress.XtraGrid.Columns.GridColumn colinativo;
        private DevExpress.XtraGrid.Columns.GridColumn collimite_de_credito;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.TextEdit tfDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoDocumento;
        private DevExpress.XtraEditors.SimpleButton btnSair;
    }
}