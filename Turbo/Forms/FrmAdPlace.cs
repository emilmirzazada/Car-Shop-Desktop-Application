using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Turbo.Classes;

namespace Turbo
{
    public partial class FrmAdPlace : Form
    {
        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        SqlUtils sqlUtils = SqlUtils.getInstance();
        InfoModel infoModel;
        
        
        public FrmAdPlace(InfoModel infoModel = null)
        {
            InitializeComponent();
            this.infoModel = infoModel;
            if (infoModel != null)
            {
                updateData();
            }

        }
        private void FrmAdPlace_Load(object sender, EventArgs e)
        {
                setBrandData();
                SetGeneralInfo(lkpEdtBodyType, "1");
                SetGeneralInfo(lkpEdtColor, "2");
                SetGeneralInfo(lkpEdtFuelType, "4");
                SetGeneralInfo(lkpEdtTransmission, "5");
                SetGeneralInfo(lkpEdtGearbox, "6");
                SetGeneralInfo(lkpEdtCities, "7");
                SetYears();
                SetGeneralInfo(lkpEdt_Engine_Capacity, "8");
                grdCntImages.DataSource = classInfoAdapter.GetImages("-1");
            if (infoModel!=null)
            {
                updateData();
            }
            
        }
        private void btn_Place_Click(object sender, EventArgs e)
        {
            if (infoModel == null)
            {
                if (ControlComponentEmpty())
                {
                    InsertALlInfo();
                }
            }
            else
            {
                if (ControlComponentEmpty())
                {
                    EditADS();
                }
            }
            this.Close();
        }

        private bool ControlComponentEmpty()
        {
            bool _control = true;
            if (lkpEdtBrands.EditValue == null) { lkpEdtBrands.ErrorText = "Markanı seçin"; _control = false; }
            if (lkpEdtModels.EditValue == null) { lkpEdtModels.ErrorText = "Modeli seçin"; _control = false; }
            if (lkpEdtBodyType.EditValue == null) { lkpEdtBodyType.ErrorText = "Ban növünü seçin"; _control = false; }
            if (lkpEdtFuelType.EditValue == null) { lkpEdtFuelType.ErrorText = "Yanacağın növünü seçin"; _control = false; }
            if (lkpEdtColor.EditValue == null) { lkpEdtColor.ErrorText = "Rəngi seçin"; _control = false; }
            if (lkpEdtTransmission.EditValue == null) { lkpEdtTransmission.ErrorText = "Ötürücünü seçin"; _control = false; }
            if (lkpEditGraduationYear.EditValue == null) { lkpEditGraduationYear.ErrorText = "Buraxılış ilini seçin"; _control = false; }
            if (lkpEdtGearbox.EditValue == null) { lkpEdtGearbox.ErrorText = "Sürətlər qutusunu seçin"; _control = false; }
            if (lkpEdt_Engine_Capacity.EditValue == null) { lkpEdt_Engine_Capacity.ErrorText = "Mühərrikin həcmini seçin"; _control = false; }
            if (tb_Name.Text == "") { tb_Name.ErrorText = "Adı daxil edin"; _control = false; }
            if (lkpEdtCities.EditValue == null) { lkpEdtCities.ErrorText = "Şəhəri seçin"; _control = false; }
            if (tb_Email.Text == "") { tb_Email.ErrorText = "Emaili daxil edin"; _control = false; }
            if (crdVwPictures.DataRowCount < 3) { MessageBox.Show("Ən azı 3 şəkil daxil edilməlidir!"); _control = false; }

            return _control;
        }

        private void InsertALlInfo()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(SqlUtils.getInstance().conString);
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                string insertedID = InsertADS(sqlTransaction);
                InsertAdsImage(sqlTransaction, insertedID);
                sqlTransaction.Commit();
                sqlConnection.Close();
                MessageBox.Show("Məlumat uğurla yadda saxlanıldı");
                this.Close();
            }
            catch (Exception)
            {
                sqlTransaction.Rollback();
                MessageBox.Show("Məlumat yadda saxlanılan zaman xəta baş verdi");
            }
        }

        private void setBrandData()
        {
            lkpEdtBrands.Properties.DataSource = classInfoAdapter.GetBrands();
            lkpEdtBrands.Properties.DisplayMember = "Brand_Name";
            lkpEdtBrands.Properties.ValueMember = "ID";
        }
        private void SetGeneralInfo(LookUpEdit lkUpEdtGenInfo, string typeID)
        {
            lkUpEdtGenInfo.Properties.DataSource = classInfoAdapter.GetGeneralInfo(typeID);
            lkUpEdtGenInfo.Properties.DisplayMember = "Name";
            lkUpEdtGenInfo.Properties.ValueMember = "ID";
        }
        private void SetYears()
        {
            List<int> listYears = new List<int>();
            int currentYear = DateTime.Now.Year;
            for (int i = 1960; i <= currentYear; i++)
            {
                listYears.Add(i);
            }
            lkpEditGraduationYear.Properties.DataSource = listYears;
        }

        private void updateData()
        {
            lkpEdtBrands.Text = infoModel.brand;
            lkpEdtModels.Text = infoModel.model;
            lkpEdtBodyType.Text = infoModel.body_type;
            nmUp_Walk.Text = infoModel.walk;
            lkpEdtColor.Text = infoModel.color;
            nmUp_Price.Text = infoModel.price;
            rdGrpCurrency.Text = infoModel.currency;

            chb_Credit.Checked = infoModel.credit;
            chb_Barter.Checked = infoModel.barter;
            cb_Additional_information.Text = infoModel.additional_information;
            lkpEdtFuelType.Text = infoModel.fuel_type;
            lkpEdtTransmission.Text = infoModel.transmission;
            lkpEdtGearbox.Text = infoModel.gearbox;
            lkpEditGraduationYear.Text = infoModel.graduation_year;
            lkpEdt_Engine_Capacity.Text = infoModel.engine_capacity;
            nmUp_Engine_Power.Value = infoModel.HP;
            chb_Alloy_wheels.Checked = infoModel.alloy_wheels;
            chb_Central_closure.Checked = infoModel.central_closure;
            chb_Leather_salon.Checked = infoModel.leather_salon;
            chb_Seat_ventilation.Checked = infoModel.seat_ventilation;
            chb_USA.Checked = infoModel.USA;
            chb_Parking_radar.Checked = infoModel.parking_radar;
            chb_Xenon.Checked = infoModel.xenon;
            chb_Luke.Checked = infoModel.luke;
            chb_Conditioner.Checked = infoModel.conditioner;
            chb_Rear_view_camera.Checked = infoModel.rear_view_camera;
            chb_Rain_sensor.Checked = infoModel.rain_sensor;
            chb_Seat_heating.Checked = infoModel.seat_heating;
            chb_Side_curtains.Checked = infoModel.side_curtains;
            tb_Name.Text = infoModel.name;
            lkpEdtCities.Text = infoModel.city;
            tb_Email.Text = infoModel.email;
            grdCntImages.DataSource = infoModel.Photos;
        }

        private string InsertADS(SqlTransaction sqlTransaction)
        {
            string _query = $@"INSERT INTO [dbo].[TB_ADS]
           ([Model_ID]
           ,[Body_Type_ID]
           ,[Walk]
           ,[Color_ID]
           ,[Price]
           ,[Currency_ID]
           ,[Credit]
           ,[Barter]
           ,[Fuel_Type_ID]
           ,[Transmission_ID]
           ,[Gearbox_ID]
           ,[Graduation_Year]
           ,[Engine_Capacity_ID]
           ,[HP]
           ,[Note]
           ,[Alloy_Wheels]
           ,[Central_Closure]
           ,[Leather_Salon]
           ,[Seat_Ventilation]
           ,[USA]
           ,[Parking_Radar]
           ,[Xenon]
           ,[Luke]
           ,[Conditioner]
           ,[Rear_Camera]
           ,[Rain_Sensor]
           ,[Seat_Heating]
           ,[Side_Curtains]
           ,[Name]
           ,[City_ID]
           ,[Email])
     VALUES
           (@Model_ID
           ,@Body_Type_ID
           ,@Walk
           ,@Color_ID
           ,@Price
           ,@Currency_ID
           ,@Credit
           ,@Barter
           ,@Fuel_Type_ID
           ,@Transmission_ID
           ,@Gearbox_ID
           ,@Graduation_Year
           ,@Engine_Capacity_ID
           ,@HP
           ,@Note
           ,@Alloy_Wheels
           ,@Central_Closure
           ,@Leather_Salon
           ,@Seat_Ventilation
           ,@USA
           ,@Parking_Radar
           ,@Xenon
           ,@Luke
           ,@Conditioner
           ,@Rear_Camera
           ,@Rain_Sensor
           ,@Seat_Heating
           ,@Side_Curtains
           ,@Name
           ,@City_ID
           ,@Email); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(_query, sqlTransaction.Connection);
            sqlCommand.Transaction = sqlTransaction;

            sqlCommand.Parameters.Add("Model_ID", SqlDbType.Int).Value = lkpEdtModels.EditValue;
            sqlCommand.Parameters.Add("Body_Type_ID", SqlDbType.Int).Value = lkpEdtBodyType.EditValue;
            sqlCommand.Parameters.Add("Walk", SqlDbType.Int).Value = nmUp_Walk.Value;
            sqlCommand.Parameters.Add("Color_ID", SqlDbType.Int).Value = lkpEdtColor.EditValue;
            sqlCommand.Parameters.Add("Price", SqlDbType.Int).Value = nmUp_Price.Value;
            sqlCommand.Parameters.Add("Currency_ID", SqlDbType.Int).Value = rdGrpCurrency.EditValue;
            sqlCommand.Parameters.Add("Credit", SqlDbType.Bit).Value = chb_Credit.Checked;
            sqlCommand.Parameters.Add("Barter", SqlDbType.Bit).Value = chb_Barter.Checked;
            sqlCommand.Parameters.Add("Note", SqlDbType.NVarChar).Value = cb_Additional_information.Text;
            sqlCommand.Parameters.Add("Fuel_Type_ID", SqlDbType.Int).Value = lkpEdtFuelType.EditValue;
            sqlCommand.Parameters.Add("Transmission_ID", SqlDbType.Int).Value = lkpEdtTransmission.EditValue;
            sqlCommand.Parameters.Add("Gearbox_ID", SqlDbType.Int).Value = lkpEdtGearbox.EditValue;
            sqlCommand.Parameters.Add("Graduation_Year", SqlDbType.Int).Value = lkpEditGraduationYear.EditValue;
            sqlCommand.Parameters.Add("Engine_Capacity_ID", SqlDbType.Int).Value = lkpEdt_Engine_Capacity.EditValue;
            sqlCommand.Parameters.Add("HP", SqlDbType.Int).Value = nmUp_Engine_Power.Text;
            sqlCommand.Parameters.Add("Alloy_Wheels", SqlDbType.Bit).Value = chb_Alloy_wheels.Checked;
            sqlCommand.Parameters.Add("Central_Closure", SqlDbType.Bit).Value = chb_Central_closure.Checked;
            sqlCommand.Parameters.Add("Leather_Salon", SqlDbType.Bit).Value = chb_Leather_salon.Checked;
            sqlCommand.Parameters.Add("Seat_Ventilation", SqlDbType.Bit).Value = chb_Seat_ventilation.Checked;
            sqlCommand.Parameters.Add("USA", SqlDbType.Bit).Value = chb_USA.Checked;
            sqlCommand.Parameters.Add("Parking_Radar", SqlDbType.Bit).Value = chb_Parking_radar.Checked;
            sqlCommand.Parameters.Add("Xenon", SqlDbType.Bit).Value = chb_Xenon.Checked;
            sqlCommand.Parameters.Add("Luke", SqlDbType.Bit).Value = chb_Luke.Checked;
            sqlCommand.Parameters.Add("Conditioner", SqlDbType.Bit).Value = chb_Conditioner.Checked;
            sqlCommand.Parameters.Add("Rear_Camera", SqlDbType.Bit).Value = chb_Rear_view_camera.Checked;
            sqlCommand.Parameters.Add("Rain_Sensor", SqlDbType.Bit).Value = chb_Rain_sensor.Checked;
            sqlCommand.Parameters.Add("Seat_Heating", SqlDbType.Bit).Value = chb_Seat_heating.Checked;
            sqlCommand.Parameters.Add("Side_Curtains", SqlDbType.Bit).Value = chb_Side_curtains.Checked;
            sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
            sqlCommand.Parameters.Add("City_ID", SqlDbType.Int).Value = lkpEdtCities.EditValue;
            sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email.Text;
            return sqlCommand.ExecuteScalar().ToString();
        }

        private void EditADS()
        {
            string _query = $@"UPDATE [dbo].[TB_ADS]
   SET [Model_ID] = @Model_ID
      ,[Body_Type_ID] = @Body_Type_ID
      ,[Walk] = @Walk
      ,[Color_ID] = @Color_ID
      ,[Price] = @Price
      ,[Currency_ID] = @Currency_ID
      ,[Credit] = @Credit
      ,[Barter] = @Barter
      ,[Fuel_Type_ID] = @Fuel_Type_ID
      ,[Transmission_ID] = @Transmission_ID
      ,[Gearbox_ID] = @Gearbox_ID
      ,[Graduation_Year] = @Graduation_Year
      ,[Engine_Capacity_ID] = @Engine_Capacity_ID
      ,[HP] = @HP
      ,[Note] =@Note
      ,[Alloy_Wheels] = @Alloy_Wheels
      ,[Central_Closure] = @Central_Closure
      ,[Leather_Salon] = @Leather_Salon
      ,[Seat_Ventilation] = @Seat_Ventilation
      ,[USA] = @USA
      ,[Parking_Radar] = @Parking_Radar
      ,[Xenon] = @Xenon
      ,[Luke] = @Luke
      ,[Conditioner] = @Conditioner
      ,[Rear_Camera] = @Rear_Camera
      ,[Rain_Sensor] = @Rain_Sensor
      ,[Seat_Heating] =@Seat_Heating
      ,[Side_Curtains] = @Side_Curtains

      ,[Name] = @Name
      ,[City_ID] = @City_ID
      ,[Email] = @Email
 WHERE ID=@ID";
            SqlConnection sqlConnection = new SqlConnection(sqlUtils.conString);
            SqlCommand cmd1 = new SqlCommand(_query, sqlConnection);


            cmd1.Parameters.Add("Model_ID", SqlDbType.Int).Value = lkpEdtModels.EditValue;
            cmd1.Parameters.Add("Body_Type_ID", SqlDbType.Int).Value = lkpEdtBodyType.EditValue;
            cmd1.Parameters.Add("Walk", SqlDbType.Int).Value = nmUp_Walk.Value;
            cmd1.Parameters.Add("Color_ID", SqlDbType.Int).Value = lkpEdtColor.EditValue;
            cmd1.Parameters.Add("Price", SqlDbType.Int).Value = nmUp_Price.Value;
            cmd1.Parameters.Add("Currency_ID", SqlDbType.Bit).Value = rdGrpCurrency.EditValue;

            cmd1.Parameters.Add("Credit", SqlDbType.Bit).Value = chb_Credit.Checked;
            cmd1.Parameters.Add("Barter", SqlDbType.Bit).Value = chb_Barter.Checked;
            cmd1.Parameters.Add("Note", SqlDbType.NVarChar).Value = cb_Additional_information.Text;
            cmd1.Parameters.Add("Fuel_Type_ID", SqlDbType.Int).Value = lkpEdtFuelType.EditValue;
            cmd1.Parameters.Add("Transmission_ID", SqlDbType.Int).Value = lkpEdtTransmission.EditValue;
            cmd1.Parameters.Add("Gearbox_ID", SqlDbType.Int).Value = lkpEdtGearbox.EditValue;
            cmd1.Parameters.Add("Graduation_Year", SqlDbType.Int).Value = lkpEditGraduationYear.EditValue;
            cmd1.Parameters.Add("Engine_Capacity_ID", SqlDbType.Int).Value = lkpEdt_Engine_Capacity.EditValue;
            cmd1.Parameters.Add("HP", SqlDbType.Int).Value = nmUp_Engine_Power.Text;
            cmd1.Parameters.Add("Alloy_Wheels", SqlDbType.Bit).Value = chb_Alloy_wheels.Checked;
            cmd1.Parameters.Add("Central_Closure", SqlDbType.Bit).Value = chb_Central_closure.Checked;
            cmd1.Parameters.Add("Leather_Salon", SqlDbType.Bit).Value = chb_Leather_salon.Checked;
            cmd1.Parameters.Add("Seat_Ventilation", SqlDbType.Bit).Value = chb_Seat_ventilation.Checked;
            cmd1.Parameters.Add("USA", SqlDbType.Bit).Value = chb_USA.Checked;
            cmd1.Parameters.Add("Parking_Radar", SqlDbType.Bit).Value = chb_Parking_radar.Checked;
            cmd1.Parameters.Add("Xenon", SqlDbType.Bit).Value = chb_Xenon.Checked;
            cmd1.Parameters.Add("Luke", SqlDbType.Bit).Value = chb_Luke.Checked;
            cmd1.Parameters.Add("Conditioner", SqlDbType.Bit).Value = chb_Conditioner.Checked;
            cmd1.Parameters.Add("Rear_Camera", SqlDbType.Bit).Value = chb_Rear_view_camera.Checked;
            cmd1.Parameters.Add("Rain_Sensor", SqlDbType.Bit).Value = chb_Rain_sensor.Checked;
            cmd1.Parameters.Add("Seat_Heating", SqlDbType.Bit).Value = chb_Seat_heating.Checked;
            cmd1.Parameters.Add("Side_Curtains", SqlDbType.Bit).Value = chb_Side_curtains.Checked;

            cmd1.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
            cmd1.Parameters.Add("City_ID", SqlDbType.Int).Value = lkpEdtCities.EditValue;
            cmd1.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email.Text;
            cmd1.Parameters.Add("ID", SqlDbType.Int).Value = infoModel.id;
            sqlConnection.Open();
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void InsertAdsImage(SqlTransaction sqlTransaction, string ADS_ID)
        { 
            DataTable dtTableImages = (DataTable)grdCntImages.DataSource;
            for (int i = 0; i < dtTableImages.Rows.Count; i++)
            {
                DataRow dtRowImage = dtTableImages.Rows[i];
                string query = $@"INSERT INTO [dbo].[ADS_Images]
           ([Car_Image]
           ,[ADS_ID])
     VALUES
           (@Car_Image
           ,@ADS_ID)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.Parameters.Add("Car_Image", SqlDbType.VarBinary).Value = dtRowImage["Car_Image"];
                sqlCommand.Parameters.Add("ADS_ID", SqlDbType.Int).Value = ADS_ID;
                sqlCommand.ExecuteNonQuery();
            }

        }

        private void lkpEdtBrands_EditValueChanged(object sender, EventArgs e)
        {
            lkpEdtModels.Properties.DataSource = classInfoAdapter.GetModels(lkpEdtBrands.EditValue.ToString());
            lkpEdtModels.Properties.DisplayMember = "Model_Name";
            lkpEdtModels.Properties.ValueMember = "ID";     

        }

        private void grpCntrlPictures_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == grpCntrlPictures.CustomHeaderButtons[0])
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image files | *.jpg;*jpeg;*png;";
                DataTable dtTableImage = (DataTable)grdCntImages.DataSource;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        dtTableImage.Rows.Add(0, GetByteImage(fileName));
                        GetByteImage(fileName);
                    }
                }
            }
            if (e.Button==grpCntrlPictures.CustomHeaderButtons[1])
            {
                grdCntImages.DataSource = classInfoAdapter.GetImages("-1");
            }
        }
        private byte[] GetByteImage(string fileName)
        {
            byte[] imgByteArray = null;
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imgByteArray = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            return imgByteArray;
        }
    }
}
