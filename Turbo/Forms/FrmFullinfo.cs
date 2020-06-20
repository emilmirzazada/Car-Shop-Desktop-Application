using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turbo.Classes;

namespace Turbo
{
    public partial class FrmFullinfo : Form
    {
        int id;
        SqlUtils sqlUtils = SqlUtils.getInstance();
        public FrmFullinfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void HomeFrm_Load(object sender, EventArgs e)
        {
            retrieveData();
        }
        private void pic_Small3_Click(object sender, EventArgs e)
        {
            pictureBox_Car_Main.Image = pic_Small3.Image;
            pictureBox_Car_Main.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pic_Small2_Click(object sender, EventArgs e)
        {
            pictureBox_Car_Main.Image = pic_Small2.Image;
            pictureBox_Car_Main.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pic_Small1_Click(object sender, EventArgs e)
        {
            pictureBox_Car_Main.Image = pic_Small1.Image;
            pictureBox_Car_Main.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void retrieveData()
        {
            string _query = $@"SELECT ADS.[ID]
	  ,(Select Top(1) img.Car_Image from ADS_Images img where img.ADS_ID=ADS.ID) as Photo1
	  ,(SELECT Car_Image FROM  ADS_Images where ADS_Images.ADS_ID=ADS.ID ORDER BY ID OFFSET 1 ROWS  FETCH NEXT 1 ROWS ONLY ) as Photo2
	  ,(SELECT Car_Image FROM  ADS_Images where ADS_Images.ADS_ID=ADS.ID ORDER BY ID OFFSET 2 ROWS  FETCH NEXT 1 ROWS ONLY ) as Photo3
	  ,(SELECT Car_Image FROM  ADS_Images where ADS_Images.ADS_ID=ADS.ID ORDER BY ID OFFSET 3 ROWS  FETCH NEXT 1 ROWS ONLY ) as Photo4
	  ,CBR.Brand_Name
	  ,CML.Model_Name
	  ,GI3.Name as Body_Type
	  ,GI4.Name as Color
	  ,[Price]
	  ,GI2.Name as Currency
	  ,Graduation_Year
	  ,Walk
	  ,GI5.Name as Gearbox
	  ,GI6.Name as Engine_Capacity
	  ,HP
	  ,GI7.Name as Fuel_Type
	  ,GI8.Name as Transmission
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
      ,Credit
      ,Barter
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
  join General_Info GI9 on GI9.ID=ADS.City_ID where ADS.[ID]=" + id;
            DataTable dt = sqlUtils.GetDataWithAdapter(_query);

            byte[] picArr1 = (byte[])dt.Rows[0]["Photo1"];
            byte[] picArr1_1 = (byte[])dt.Rows[0]["Photo2"];
            byte[] picArr1_2 = (byte[])dt.Rows[0]["Photo3"];
            byte[] picArr1_3 = (byte[])dt.Rows[0]["Photo4"];
            pictureBox_Car_Main.Image = (Bitmap)((new ImageConverter()).ConvertFrom(picArr1));
            pictureBox1.Image = pictureBox_Car_Main.Image;
            pic_Small1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(picArr1_1));
            pic_Small2.Image = (Bitmap)((new ImageConverter()).ConvertFrom(picArr1_2));
            pic_Small3.Image = (Bitmap)((new ImageConverter()).ConvertFrom(picArr1_3));

            lbl_FuelType.Text = dt.Rows[0]["Fuel_Type"].ToString();
            lbl_Transmission.Text = dt.Rows[0]["Transmission"].ToString();
            lbl_City.Text = dt.Rows[0]["City"].ToString();
            lbl_Cat_brand1.Text = dt.Rows[0]["Brand_Name"].ToString();
            lbl_Cat_Model1.Text = dt.Rows[0]["Model_Name"].ToString();
            lbl_Grad.Text = dt.Rows[0]["Graduation_Year"].ToString();
            lbl_BodyType.Text = dt.Rows[0]["Body_Type"].ToString();
            lbl_Color.Text = dt.Rows[0]["Color"].ToString();
            lbl_EngineCapacity.Text = dt.Rows[0]["Engine_Capacity"].ToString();
            lbl_EnginePower.Text = dt.Rows[0]["HP"].ToString();
            lbl_Walk.Text = dt.Rows[0]["Walk"].ToString();
            lbl_Gearbox.Text = dt.Rows[0]["Gearbox"].ToString();
            lbl_CatPrice1.Text = dt.Rows[0]["Price"].ToString();
            lbl_Marka.Text = lbl_Cat_brand1.Text;
            lbl_Model.Text = lbl_Cat_Model1.Text;
            if (dt.Rows[0]["Currency"].ToString()=="AZN")
                lbl_CatPrice1.Text += "\nAZN";
            else if (dt.Rows[0]["Currency"].ToString() == "USD")
                lbl_CatPrice1.Text += "$";
            else
                lbl_CatPrice1.Text += "\nEUR";
            lbl_Price_Main.Text = lbl_CatPrice1.Text;
            lbl_Price.Text = lbl_CatPrice1.Text;

            chkCredit.Checked = (bool)dt.Rows[0]["Credit"];
            if (chkCredit.Checked) chkCredit.ForeColor = Color.Green;
            else chkCredit.ForeColor = Color.Red;
            chkBarter.Checked = (bool)dt.Rows[0]["Barter"];
            if (chkBarter.Checked) chkBarter.ForeColor = Color.Green;
            else chkBarter.ForeColor = Color.Red;

            chkAlloyWheels.Checked = (bool)dt.Rows[0]["Alloy_Wheels"];
            if (chkAlloyWheels.Checked) chkAlloyWheels.ForeColor = Color.Green;
            else chkAlloyWheels.ForeColor = Color.Red;
            chkUSA.Checked = (bool)dt.Rows[0]["USA"];
            if (chkUSA.Checked) chkUSA.ForeColor = Color.Green;
            else chkUSA.ForeColor = Color.Red;
            chkLuke.Checked = (bool)dt.Rows[0]["Luke"];
            if (chkLuke.Checked) chkLuke.ForeColor = Color.Green;
            else chkLuke.ForeColor = Color.Red;
            chkRainSensor.Checked = (bool)dt.Rows[0]["Rain_Sensor"];
            if (chkRainSensor.Checked) chkRainSensor.ForeColor = Color.Green;
            else chkRainSensor.ForeColor = Color.Red;
            chkCentralClosure.Checked = (bool)dt.Rows[0]["Central_Closure"];
            if (chkCentralClosure.Checked) chkCentralClosure.ForeColor = Color.Green;
            else chkCentralClosure.ForeColor = Color.Red;
            chkParkingRadar.Checked = (bool)dt.Rows[0]["Parking_Radar"];
            if (chkParkingRadar.Checked) chkParkingRadar.ForeColor = Color.Green;
            else chkParkingRadar.ForeColor = Color.Red;
            chkConditioner.Checked = (bool)dt.Rows[0]["Conditioner"];
            if (chkConditioner.Checked) chkConditioner.ForeColor = Color.Green;
            else chkConditioner.ForeColor = Color.Red;
            chkSeatHeating.Checked = (bool)dt.Rows[0]["Seat_Heating"];
            if (chkSeatHeating.Checked) chkSeatHeating.ForeColor = Color.Green;
            else chkSeatHeating.ForeColor = Color.Red;
            chkLeatherSalon.Checked = (bool)dt.Rows[0]["Leather_Salon"];
            if (chkLeatherSalon.Checked) chkLeatherSalon.ForeColor = Color.Green;
            else chkLeatherSalon.ForeColor = Color.Red;
            chkXenon.Checked = (bool)dt.Rows[0]["Xenon"];
            if (chkXenon.Checked) chkXenon.ForeColor = Color.Green;
            else chkXenon.ForeColor = Color.Red;
            chkRearViewCamera.Checked = (bool)dt.Rows[0]["Rear_Camera"];
            if (chkRearViewCamera.Checked) chkRearViewCamera.ForeColor = Color.Green;
            else chkRearViewCamera.ForeColor = Color.Red;
            chkSideCurtains.Checked = (bool)dt.Rows[0]["Side_Curtains"];
            if (chkSideCurtains.Checked) chkSideCurtains.ForeColor = Color.Green;
            else chkSideCurtains.ForeColor = Color.Red;
            chkSeatVentilation.Checked = (bool)dt.Rows[0]["Seat_Ventilation"];
            if (chkSeatVentilation.Checked) chkSeatVentilation.ForeColor = Color.Green;
            else chkSeatVentilation.ForeColor = Color.Red;

            chkAlloyWheels.Enabled = false; chkUSA.Enabled = false; chkLuke.Enabled = false;
            chkRainSensor.Enabled = false; chkCentralClosure.Enabled = false;
            chkParkingRadar.Enabled = false; chkConditioner.Enabled = false;
            chkSeatHeating.Enabled = false; chkLeatherSalon.Enabled = false; chkXenon.Enabled = false;
            chkRearViewCamera.Enabled = false; chkSideCurtains.Enabled = false;
            chkSeatVentilation.Enabled = false; chkBarter.Enabled = false; chkCredit.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_Car_Main.Image = pictureBox1.Image;
        }
    }
}