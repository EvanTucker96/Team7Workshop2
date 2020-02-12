using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using TravelExperts.Data;

namespace TravelExperts.Utility
{
    public static class Util
    {
        public static Product Get(Product[] list, int id)
        {
            var query = from Product
                            in list
                        where Product.ProductId == id
                        select Product;
            return query.First();
        }

        public static Package Get(Package[] list, int id)
        {
            var query = from Package
                            in list
                        where Package.PackageId == id
                        select Package;
            return query.First();
        }

        public static Supplier[] Get(Supplier[] list, Products_Supplier[] list2, int id)
        {
            var query = from Supplier
                            in list
                        join Product_Supplier
                            in list2
                            on id equals Product_Supplier.ProductId
                        where Supplier.SupplierId == Product_Supplier.SupplierId
                        select Supplier;

            return query.ToArray();
        }

        public static Products_Supplier[] Get(Products_Supplier[] list, int id)
        {
            var query = from Products_Supplier
                            in list
                        where Products_Supplier.ProductId == id
                        select Products_Supplier;
            return query.ToArray();
        }

        public static BookingDetail[] Get(BookingDetail[] list, int id)
        {
            var query = from BookingDetail
                            in list
                        where BookingDetail.ProductSupplierId == id
                        select BookingDetail;
            return query.ToArray();
        }

        public static BookingDetail[] Get(BookingDetail[] list, int[] ids)
        {
            var result = new List<BookingDetail>();
            ids.ToList().ForEach(id =>
            {
                result.AddRange(Get(list, id));
            });
            return result.ToArray();
        }

        public static BookingDetail[] Get(BookingDetail[] list, Products_Supplier[] suppliers)
        {
            var result = new List<BookingDetail>();
            suppliers.ToList().ForEach(supplier =>
            {
                result.AddRange(Get(list, supplier.ProductSupplierId));
            });
            return result.ToArray();
        }

        public static BookingDetail[] Get(BookingDetail[] list, Products_Supplier supplier)
        {
            var result = new List<BookingDetail>();
            result.AddRange(Get(list, supplier.ProductSupplierId));
            return result.ToArray();
        }

        public static Packages_Products_Supplier[] Get(Packages_Products_Supplier[] list, int id)
        {
            var query = from Packages_Products_Supplier
                            in list
                        where Packages_Products_Supplier.ProductSupplierId == id
                        select Packages_Products_Supplier;
            return query.ToArray();
        }

        public static Packages_Products_Supplier[] Get(Packages_Products_Supplier[] list, Products_Supplier supplier)
        {
            var result = new List<Packages_Products_Supplier>();
            result.AddRange(Get(list, supplier.ProductSupplierId));
            return result.ToArray();
        }

        public static Packages_Products_Supplier[] Get(Packages_Products_Supplier[] list, Products_Supplier[] suppliers)
        {
            var result = new List<Packages_Products_Supplier>();
            suppliers.ToList().ForEach(supplier =>
            {
                result.AddRange(Get(list, supplier.ProductSupplierId));
            });
            return result.ToArray();
        }

        public static int GetIndex(Product[] list, int id)
        {
            var result = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].ProductId != id)
                    continue;

                result = i;
                break;
            }

            return result;
        }

        public static int GetIndex(Package[] list, int id)
        {
            var result = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].PackageId != id)
                    continue;

                result = i;
                break;
            }

            return result;
        }

        // Hash
        private static byte[] HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return provider.ComputeHash(encoding.GetBytes(password));
        }
        // Encode hash to string
        private static string EncodeHash(byte[] hash)
            => Encoding.UTF8.GetString(hash, 0, hash.Length);

        // Encrypt
        public static string EncryptPassword(string password)
        {
            var hash = HashPassword(password);
            return EncodeHash(hash);
        }
        public static string Encrypt(string password)
            => EncryptPassword(password);

        // Authentication
        public static bool IsAuthenticated(HttpSessionState session)
            => session["IsAuthenticated"] != null && (bool)session["IsAuthenticated"];
    }
}
