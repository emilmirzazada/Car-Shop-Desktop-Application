using System.Data;

namespace Turbo.Classes
{
    class ClassInfoAdapter
    {
        SqlUtils sqlUtils = SqlUtils.getInstance();
        public DataTable GetBrands()
        {
            string _query = "Select ID, Brand_Name from Car_Brands";
            return sqlUtils.GetDataWithAdapter(_query);
        }
        public DataTable GetModels(string brandId)
        {
            string _query = $"Select ID, Model_Name from Car_Models where Brand_ID={brandId}";
            return sqlUtils.GetDataWithAdapter(_query);
        }
        public DataTable GetGeneralInfo(string typeID)
        {
            string _query = $"Select ID, Name from General_Info where Type_ID={typeID}";
            return sqlUtils.GetDataWithAdapter(_query);
        }
        public DataTable GetImages(string ADS_ID)
        {
            string query = $"SELECT [ID],[Car_Image],[ADS_ID] FROM[dbo].[ADS_Images] where ADS_ID={ADS_ID}";
            return SqlUtils.getInstance().GetDataWithAdapter(query);
        }
    }
}
