using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any()|| _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB ja foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books"); //Tanto faz

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 9, 21), 2700.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1968, 8, 11), 4200.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1982, 11, 14), 5400.0, d2);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1991, 4, 27), 2500.0, d3);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 1900.0, d4);
            Seller s6 = new Seller(6, "Alex Pink", "alex@gmail.com", new DateTime(1994, 6, 4), 3000.0, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 4, 25), 5000.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 6, 25), 8000.0, SaleStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 9, 25), 9000.0, SaleStatus.Billed, s2);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 7, 25), 1000.0, SaleStatus.Billed, s2);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 2, 25), 4000.0, SaleStatus.Billed, s6);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 3, 25), 2000.0, SaleStatus.Billed, s6);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 9, 25), 8000.0, SaleStatus.Billed, s1);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 1, 25), 3000.0, SaleStatus.Billed, s1);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2019, 8, 25), 6000.0, SaleStatus.Billed, s1);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2019, 11, 25), 9000.0, SaleStatus.Billed, s1);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2019, 9, 25), 3000.0, SaleStatus.Billed, s1);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2019, 12, 25), 3500.0, SaleStatus.Billed, s1);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2019, 1, 25), 6000.0, SaleStatus.Billed, s1);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2019, 9, 25), 5000.0, SaleStatus.Billed, s3);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2019, 4, 25), 8000.0, SaleStatus.Billed, s3);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2019, 9, 25), 4000.0, SaleStatus.Billed, s3);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2020, 7, 25), 7000.0, SaleStatus.Billed, s3);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2020, 12, 25), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2020, 12, 25), 2000.0, SaleStatus.Billed, s3);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2020, 9, 25), 4000.0, SaleStatus.Billed, s3);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2020, 9, 25), 7000.0, SaleStatus.Billed, s4);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2020, 6, 25), 9000.0, SaleStatus.Billed, s4);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2021, 9, 25), 4000.0, SaleStatus.Billed, s6);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2021, 10, 25), 6000.0, SaleStatus.Billed, s5);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2021, 10, 25), 8000.0, SaleStatus.Billed, s5);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2021, 9, 25), 5000.0, SaleStatus.Billed, s5);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2021, 2, 25), 3000.0, SaleStatus.Billed, s5);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2021, 9, 25), 5000.0, SaleStatus.Billed, s5);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2021, 2, 25), 14000.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4,s5,s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6,
                sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15, sr16,
                sr17, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26,
                sr27, sr28, sr29, sr30
                );
            _context.SaveChanges();
        }

    }
}
