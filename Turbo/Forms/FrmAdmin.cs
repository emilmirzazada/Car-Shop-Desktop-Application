using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turbo.Classes;

namespace Turbo
{
    public partial class Form1 : Form
    {
        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        SqlUtils sqlUtils = SqlUtils.getInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            retrieveInfo();

        }


        private void retrieveInfo()
        {
            string _query = $@"SELECT ADS.[ID] as ID
	  ,(Select Top(1) img.Car_Image from ADS_Images img where img.ADS_ID=ADS.ID) as Photo1
	  ,(SELECT Car_Image FROM  ADS_Images where ADS_Images.ADS_ID=ADS.ID ORDER BY ID OFFSET 1 ROWS  FETCH NEXT 1 ROWS ONLY ) as Photo2
	  ,(SELECT Car_Image FROM  ADS_Images where ADS_Images.ADS_ID=ADS.ID ORDER BY ID OFFSET 2 ROWS  FETCH NEXT 1 ROWS ONLY ) as Photo3
	  ,(SELECT Car_Image FROM  ADS_Images where ADS_Images.ADS_ID=ADS.ID ORDER BY ID OFFSET 3 ROWS  FETCH NEXT 1 ROWS ONLY ) as Photo4
	  ,CBR.Brand_Name
	  ,CML.Model_Name
	  ,GI3.Name as Body_Type
	  ,Walk
	  ,GI4.Name as Color
	  ,[Price]
	  ,GI2.Name as Currency
	  ,Credit
      ,Barter
	  ,Note
	  ,GI7.Name as Fuel_Type
	  ,GI8.Name as Transmission
	  ,GI5.Name as Gearbox
	  ,Graduation_Year
	  ,GI6.Name as Engine_Capacity
	  ,HP
	  ,GI9.Name City
	  ,Alloy_Wheels
	  ,USA
	  ,Luke
	  ,Rain_Sensor
	  ,Central_Closure
	  ,Parking_Radar
	  ,Conditioner
	  ,Seat_Heating
	  ,Leather_Salon
	  ,Xenon
	  ,Rear_Camera
	  ,Side_Curtains
	  ,Seat_Ventilation
	  ,ADS.Name
	  ,Email
  FROM [dbo].[TB_ADS] ADS
  join Car_Models CML on CML.ID=ADS.Model_ID
  join Car_Brands CBR on CBR.ID=CML.Brand_ID
  join General_Info GI1 on GI1.ID=ADS.City_ID
  join General_Info GI2 on GI2.ID=ADS.Currency_ID
  join General_Info GI3 on GI3.ID=ADS.Body_Type_ID
  join General_Info GI4 on GI4.ID=ADS.Color_ID
  join General_Info GI5 on GI5.ID=ADS.Gearbox_ID
  join General_Info GI6 on GI6.ID=ADS.Engine_Capacity_ID
  join General_Info GI7 on GI7.ID=ADS.Fuel_Type_ID
  join General_Info GI8 on GI8.ID=ADS.Transmission_ID
  join General_Info GI9 on GI9.ID=ADS.City_ID";
            Control.DataSource = sqlUtils.GetDataWithAdapter(_query);
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlUtils.conString);
            string _query = "Delete from info where ID="+ grdC_Info.GetFocusedRowCellValue("ID").ToString();
            SqlCommand sqlCommand = new SqlCommand(_query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            retrieveInfo();
            MessageBox.Show("Uğurla silindi");
        }

        private void Control_Click(object sender, EventArgs e)
        {
            picShow1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(grdC_Info.GetFocusedRowCellValue("Photo1")));
            picShow2.Image = (Bitmap)((new ImageConverter()).ConvertFrom(grdC_Info.GetFocusedRowCellValue("Photo2")));
            picShow3.Image = (Bitmap)((new ImageConverter()).ConvertFrom(grdC_Info.GetFocusedRowCellValue("Photo3")));
            picShow4.Image = (Bitmap)((new ImageConverter()).ConvertFrom(grdC_Info.GetFocusedRowCellValue("Photo4")));
            picShow1.SizeMode = PictureBoxSizeMode.Zoom;
            picShow2.SizeMode = PictureBoxSizeMode.Zoom;
            picShow3.SizeMode = PictureBoxSizeMode.Zoom;
            picShow4.SizeMode = PictureBoxSizeMode.Zoom;

            lbl_Brand.Text = grdC_Info.GetFocusedRowCellValue("Brand_Name").ToString();
            lbl_Model.Text = grdC_Info.GetFocusedRowCellValue("Model_Name").ToString();
            lbl_Price.Text = grdC_Info.GetFocusedRowCellValue("Price").ToString();
            lbl_Graduation_Year.Text = grdC_Info.GetFocusedRowCellValue("Graduation_Year").ToString() + " *  ";
            lbl_Engine_Capacity.Text = grdC_Info.GetFocusedRowCellValue("Engine_Capacity").ToString() + " *  ";
            lbl_Walk.Text = grdC_Info.GetFocusedRowCellValue("Walk").ToString();
            lbl_City.Text = grdC_Info.GetFocusedRowCellValue("City").ToString();

            if (grdC_Info.GetFocusedRowCellValue("Currency").ToString()=="AZN")
                lbl_Currency.Text = "AZN";
            else if (grdC_Info.GetFocusedRowCellValue("Currency").ToString() == "USD")
                lbl_Currency.Text = "$";
            else
                lbl_Currency.Text = "EUR";

            lbl_Brand.Visible = true;
            lbl_Model.Visible = true;
            lbl_Price.Visible = true;
            lbl_Graduation_Year.Visible = true;
            lbl_Engine_Capacity.Visible = true;
            lbl_Walk.Visible = true;
            lbl_City.Visible = true;
            lbl_Currency.Visible = true;
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataTable Photos = classInfoAdapter.GetImages($"{((int)grdC_Info.GetFocusedRowCellValue("ID"))}");
            
            InfoModel infoModel = new InfoModel
                ((int)grdC_Info.GetFocusedRowCellValue("ID")
                , grdC_Info.GetFocusedRowCellValue("Brand_Name").ToString()
                , grdC_Info.GetFocusedRowCellValue("Model_Name").ToString()
                , grdC_Info.GetFocusedRowCellValue("Body_Type").ToString()
                , grdC_Info.GetFocusedRowCellValue("Walk").ToString()
                , grdC_Info.GetFocusedRowCellValue("Color").ToString()
                , grdC_Info.GetFocusedRowCellValue("Price").ToString()
                , grdC_Info.GetFocusedRowCellValue("Currency").ToString()
                , (bool)grdC_Info.GetFocusedRowCellValue("Credit")
                , (bool)grdC_Info.GetFocusedRowCellValue("Barter")
                , grdC_Info.GetFocusedRowCellValue("Note").ToString()
                , grdC_Info.GetFocusedRowCellValue("Fuel_Type").ToString()
                , grdC_Info.GetFocusedRowCellValue("Transmission").ToString()
                , grdC_Info.GetFocusedRowCellValue("Gearbox").ToString()
                , grdC_Info.GetFocusedRowCellValue("Graduation_Year").ToString()
                , grdC_Info.GetFocusedRowCellValue("Engine_Capacity").ToString()
                , (int)grdC_Info.GetFocusedRowCellValue("HP")
                , (bool)grdC_Info.GetFocusedRowCellValue("Alloy_Wheels")
                , (bool)grdC_Info.GetFocusedRowCellValue("Central_Closure")
                , (bool)grdC_Info.GetFocusedRowCellValue("Leather_Salon")
                , (bool)grdC_Info.GetFocusedRowCellValue("Seat_Ventilation")
                , (bool)grdC_Info.GetFocusedRowCellValue("USA")
                , (bool)grdC_Info.GetFocusedRowCellValue("Parking_Radar")
                , (bool)grdC_Info.GetFocusedRowCellValue("Xenon")
                , (bool)grdC_Info.GetFocusedRowCellValue("Luke")
                , (bool)grdC_Info.GetFocusedRowCellValue("Conditioner")
                , (bool)grdC_Info.GetFocusedRowCellValue("Rear_Camera")
                , (bool)grdC_Info.GetFocusedRowCellValue("Rain_Sensor")
                , (bool)grdC_Info.GetFocusedRowCellValue("Seat_Heating")
                , (bool)grdC_Info.GetFocusedRowCellValue("Side_Curtains")
                , grdC_Info.GetFocusedRowCellValue("Name").ToString()
                , grdC_Info.GetFocusedRowCellValue("City").ToString()
                , grdC_Info.GetFocusedRowCellValue("Email").ToString()
                , Photos
                );
            FrmAdPlace frmAdPlace = new FrmAdPlace(infoModel);
            this.Hide();
            frmAdPlace.Show();
            retrieveInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            FrmCatalog frmCatalog = new FrmCatalog();
            this.Close();
            frmCatalog.Show();
        }
    }
}
