using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
using Turbo.Classes;

namespace Turbo
{
    public partial class FrmCatalog : Form
    {
        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        SqlUtils sqlUtils = SqlUtils.getInstance();
        public FrmCatalog()
        {
            InitializeComponent();
        }

        private void FrmCatalog_Load(object sender, EventArgs e)
        {
            retrieveInfo();
            setBrandData();
            SetGeneralInfo(lkpEdtCurrencyFilter, "3");
            SetGeneralInfo(lkpEdtCitiesFilter, "7");
        }
        private void setBrandData()
        {
            string _query = @"Select  ID, Brand_Name
            from Car_Brands
            Union
            Select - 1, N'Bütün markalar'";
            lkpEdtBrandsFilter.Properties.DataSource = sqlUtils.GetDataWithAdapter(_query);
            lkpEdtBrandsFilter.Properties.DisplayMember = "Brand_Name";
            lkpEdtBrandsFilter.Properties.ValueMember = "ID";
        }
        private void SetGeneralInfo(LookUpEdit lkUpEdtGenInfo, string typeID)
        {
            lkUpEdtGenInfo.Properties.DataSource = classInfoAdapter.GetGeneralInfo(typeID);
            lkUpEdtGenInfo.Properties.DisplayMember = "Name";
            lkUpEdtGenInfo.Properties.ValueMember = "ID";
        }
        private void lkpEdtBrandsFilter_EditValueChanged(object sender, EventArgs e)
        {
            string _query = $@"Select ID, Model_Name from Car_Models where Brand_ID={lkpEdtBrandsFilter.EditValue.ToString()}
                Union
                Select - 1, N'Bütün modellər'";
            lkpEdtModelsFilter.Properties.DataSource = sqlUtils.GetDataWithAdapter(_query);
            lkpEdtModelsFilter.Properties.DisplayMember = "Model_Name";
            lkpEdtModelsFilter.Properties.ValueMember = "ID";
        }

        
        private void retrieveInfo()
        {
            string _query1 = $@"SELECT ADS.[ID]
	  ,CBR.Brand_Name
	  ,CML.Model_Name
      ,[Walk]
      ,GI1.Name as Color
      ,[Price]
	  ,GI2.Name as Currency
	  ,Graduation_Year
	  ,GI3.Name as Engine_Capacity
	  ,(Select Top(1) img.Car_Image from ADS_Images img where img.ADS_ID=ADS.ID) as Photo1
	  ,GI4.Name as City
  FROM [dbo].[TB_ADS] ADS
  join Car_Models CML on CML.ID=ADS.Model_ID
  join Car_Brands CBR on CBR.ID=CML.Brand_ID
  join General_Info GI1 on GI1.ID=ADS.Color_ID
  join General_Info GI2 on GI2.ID=ADS.Currency_ID
  join General_Info GI3 on GI3.ID=ADS.Engine_Capacity_ID
  join General_Info GI4 on GI4.ID=ADS.City_ID";
            Control_Cars.DataSource = sqlUtils.GetDataWithAdapter(_query1);
        }
        
        private void btn_addAd_Click(object sender, EventArgs e)
        {
            FrmAdPlace frmAdPlace = new FrmAdPlace();
            this.Hide();
            frmAdPlace.ShowDialog();
            this.Close();
        }

        private void cardView_Cars_Click(object sender, EventArgs e)
        {
            int id = (int)cardView_Cars.GetFocusedRowCellValue("ID");

            FrmFullinfo frmFullinfo = new FrmFullinfo(id);
            frmFullinfo.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string _query1 = $@"SELECT ADS.[ID]
      ,(Select Top(1) img.Car_Image from ADS_Images img where img.ADS_ID=ADS.ID) as Photo1
	  ,CBR.Brand_Name
	  ,CML.Model_Name
      ,Walk
	  ,Price
	  ,GI1.Name as Currency
	  ,Credit
	  ,Barter
	  ,Graduation_Year
	  ,GI2.Name as City
	  ,GI3.Name as Engine_Capacity
  FROM [dbo].[TB_ADS] ADS
  join Car_Models CML on CML.ID=ADS.Model_ID
  join Car_Brands CBR on CBR.ID=CML.Brand_ID
  join General_Info GI1 on GI1.ID=ADS.Currency_ID
  join General_Info GI2 on GI2.ID=ADS.City_ID
  join General_Info GI3 on GI3.ID=ADS.Engine_Capacity_ID where GI1.Name = '{lkpEdtCurrencyFilter.Text}'";
            
            if (lkpEdtBrandsFilter.Text != "Bütün markalar") _query1 += $" and Brand_Name='{lkpEdtBrandsFilter.Text}'";
            if (lkpEdtModelsFilter.Text != "Bütün modellər") _query1 += $"and Model_Name='{lkpEdtModelsFilter.Text}'";
            if (txtMinPrice.Text != "") _query1 += $"and Price>'{txtMinPrice.Text}'";
            if (txtMaxPrice.Text != "") _query1 += $"and Price<'{txtMaxPrice.Text}'";
            if (txtMinGrad.Text != "") _query1 += $"and Graduation_Year>'{txtMinGrad.Text}'";
            if (txtMaxGrad.Text != "") _query1 += $"and Graduation_Year<'{txtMaxGrad.Text}'";
            if (lkpEdtCitiesFilter.Text != "Bütün şəhərlər") _query1 += $"and GI2.Name=N'{lkpEdtCitiesFilter.Text}'";
            if (chkCredit.Checked) _query1 += $"and Credit='{chkCredit.Checked}'";
            if (chkBarter.Checked) _query1 += $"and Barter='{chkBarter.Checked}'";
            Control_Cars.DataSource = sqlUtils.GetDataWithAdapter(_query1);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
            
        }

        private void FrmCatalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Control_Cars_Click(object sender, EventArgs e)
        {

        }
    }
}
