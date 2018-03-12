using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this is all the product supplier database operation include insert delete update select etc
//David Shen 
namespace package_product_supplier
{
    public static class Package_Product_SupplierDB
    {


        public static List<Packages> loadPackage()
        {
            List<Packages> info = new List<Packages>();
            SqlConnection connection = connectionDB.GetConnection();
            string selectstatement = "select PkgName,PackageId " +
                                     "from Packages ";



            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Packages initialize = new Packages();
                    initialize.packageid = (int)reader["PackageId"];
                    initialize.packagename = reader["PkgName"].ToString();
                    info.Add(initialize);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return info;
        }

        public static List<Supplier> loadSuppliers()
        {
            List<Supplier> info = new List<Supplier>();
            SqlConnection connection = connectionDB.GetConnection();
            string selectstatement = "select Supname " +
                                     "from suppliers " +
                                     "order by Supname";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Supplier initialize = new Supplier();
                    
                    initialize.suppliername = reader["supname"].ToString();
                    info.Add(initialize);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return info;
        }

        public static List<product> loadProduct()
        {
            List<product> info = new List<product>();
            SqlConnection connection = connectionDB.GetConnection();
            string selectstatement = "select ProdName " +
                                     "from products";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    product initialize = new product();
                    initialize.Productname = reader["ProdName"].ToString();
                    info.Add(initialize);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return info;
        }

        public static List<product_suppliers> getProduct_Suppliers(string product_name, string supplier_name)
        {
            List<product_suppliers> product_supplier_info = new List<product_suppliers>();
            SqlConnection connection = connectionDB.GetConnection();
            string selectstatement = "select p.ProdName,s.SupName from Products_Suppliers ps " +
                                    "inner join Products p on p.ProductId = ps.ProductId " +
                                    "inner join Suppliers s on s.SupplierId = ps.supplierId " +
                                    "where p.ProdName = @ProdName and s.SupName = @Suppliername";
            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@ProdName", product_name);
            selectCommand.Parameters.AddWithValue("@Suppliername", supplier_name);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    product_suppliers initialize_info = new product_suppliers();
                    initialize_info.Productname = reader["ProdName"].ToString();
                    initialize_info.Suppliername = reader["SupName"].ToString();
                    product_supplier_info.Add(initialize_info);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return product_supplier_info;
        }

        public static List<package_product_supplier> getPackageinfo(string packageName)
        {
            List<package_product_supplier> package_info = new List<package_product_supplier>();
            SqlConnection connection = connectionDB.GetConnection();
            string selectstatement = "select s.SupplierId,p.ProductId,ps.ProductSupplierId,pk.PkgName,p.ProdName,s.SupName,pps.PackageId " +
                                   "from Packages pk inner join Packages_Products_Suppliers pps " +
                                   "on pk.PackageId=pps.PackageId inner join Products_Suppliers ps " +
                                   "on pps.ProductSupplierId=ps.ProductSupplierId inner join Suppliers s on " +
                                   "ps.SupplierId=s.SupplierId inner join Products p on p.ProductId=ps.ProductId " +
                                   "where pk.PkgName=@packagename";

            SqlCommand selectCommand = new SqlCommand(selectstatement, connection);
            selectCommand.Parameters.AddWithValue("@packagename", packageName);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    package_product_supplier initialize_info = new package_product_supplier();
                    initialize_info.packageid = (int)reader["PackageId"];
                    initialize_info.packagename = reader["PkgName"].ToString();
                    initialize_info.Productid = (int)reader["ProductId"];
                    initialize_info.Productname = reader["ProdName"].ToString();
                    initialize_info.supplierid = (int)reader["SupplierId"];
                    initialize_info.suppliername = reader["SupName"].ToString();
                    initialize_info.productsupplierid = (int)reader["ProductSupplierId"];
                    package_info.Add(initialize_info);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return package_info;
        }

        public static bool Update_info(string packagename,string old_product_name,string old_supplier_name,string newproductname,string newsuppliername)
        {
            SqlConnection connection = connectionDB.GetConnection();
            string updateCommand = "update Packages_Products_Suppliers " +
                                 "set ProductSupplierId=( "+
                                 "select ps.ProductSupplierId as product_supplier_id from Products_Suppliers ps " +
                                 "inner join Products p on ps.ProductId=p.ProductId " +
                                 "inner join Suppliers s on s.SupplierId=ps.SupplierId " +
                                 "where s.SupName=@new_supplier_name and p.ProdName=@new_product_name) " +
                                 "where packageid = (select PackageId from Packages where PkgName = @packagename) " +
                                 "and ProductSupplierId=(select ps.ProductSupplierId as product_supplier_id from Packages_Products_Suppliers pps " +
                                 "inner join Products_Suppliers ps on ps.ProductSupplierId = pps.ProductSupplierId "+
                                 "inner join Products p on ps.ProductId=p.ProductId " +
                                 "inner join Suppliers s on s.SupplierId = ps.SupplierId " +
                                 "where s.SupName=@old_supplier_name and p.ProdName=@old_product_name)";
                    //string sql = "UPDATE Packages_Products_Suppliers SET ProductSupplierId=@newPSId"
            SqlCommand selectCommand = new SqlCommand(updateCommand, connection);
            selectCommand.Parameters.AddWithValue("@new_supplier_name", newsuppliername);
            selectCommand.Parameters.AddWithValue("@new_product_name", newproductname);
            selectCommand.Parameters.AddWithValue("@packagename", packagename);
            selectCommand.Parameters.AddWithValue("@old_supplier_name", old_supplier_name);
            selectCommand.Parameters.AddWithValue("@old_product_name", old_product_name);
            try
            {
                connection.Open();
                int count = selectCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }

                else
                {
                   
                    return false;
                }

            }
            catch (SqlException ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }



        }
        public static bool insert_info(string packagename,string productname,string suppliername)
        {
            SqlConnection connection = connectionDB.GetConnection();
            string selectionCommand = "insert into Packages_Products_Suppliers(Packageid, ProductSupplierId) " +
                                "select PackageId,product_supplier_id from " +
                                "(select ps.ProductSupplierId as product_supplier_id " +
                                "from Products_Suppliers ps " +
                                "inner join Products p on ps.ProductId=p.ProductId " +
                                "inner join Suppliers s on s.SupplierId=ps.SupplierId " +
                                "where s.SupName=@suppliername and p.ProdName=@productname) t1, " +
                                "(select PackageId from Packages where PkgName=@packagename) t2";
            SqlCommand selectCommand = new SqlCommand(selectionCommand, connection);
            selectCommand.Parameters.AddWithValue("@packagename", packagename);
            selectCommand.Parameters.AddWithValue("@productname", productname);
            selectCommand.Parameters.AddWithValue("@suppliername", suppliername);
            try
            {
                connection.Open();
                int count = selectCommand.ExecuteNonQuery();
                if (count > 0)
                {
                   
                    return true;
                }

                else
                {

                   
                    return false;
                }

            }
            catch (SqlException ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }


        }

        public static bool delete_info(int package_id,int product_id,int Supplier_id)
        {

            SqlConnection con = connectionDB.GetConnection();
            string Delete_order = "delete from Packages_Products_Suppliers " +
                                  "where ProductSupplierId in " +
                                  "(select pps.ProductSupplierId " +
                                  "from Products_Suppliers pps " +
                                  "inner join Products_Suppliers ps on ps.ProductSupplierId=pps.ProductSupplierId "+
                                  "inner join Products p on p.ProductId = ps.ProductId "+
                                  "inner join Suppliers s on s.supplierid = s.SupplierId "+
                                  "where s.SupplierId =@Supplier_id "+
                                  "AND p.ProductId =@Product_id "+
                                  "AND PackageId =@PackageID) ";

            SqlCommand DeleteCommand = new SqlCommand(Delete_order, con);
            DeleteCommand.Parameters.AddWithValue("@Supplier_id", Supplier_id);
            DeleteCommand.Parameters.AddWithValue("@Product_id", product_id);
            DeleteCommand.Parameters.AddWithValue("@PackageID", package_id);
            
            try
            {
                con.Open();
                int count = DeleteCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show(count.ToString() + "Deleted");
                    return true;
                }

                else
                {
                    MessageBox.Show("Fail to Delete");
                    return false;
                }
                    
            }
            catch (SqlException ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}