using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SelectWebMvc.Models;
using SelectWebMvc.Models.Enums;

namespace SelectWebMvc.Data
{
    public class SeedingService
    {
        private readonly SelectWebMvcContext _context;

        public SeedingService(SelectWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Ying", "real.ying@gmail.com",new DateTime(1998, 7, 21),
                1000.0,d1);
            Seller s2 = new Seller(2, "Fernando", "fernando.im@gmail.com", new DateTime(1995, 3, 7),
                1550.50, d2);
            Seller s3 = new Seller(3, "Lian", "lian.queen@gmail.com", new DateTime(1990, 11, 23),
                2700.0, d3);
            Seller s4 = new Seller(4, "Talus", "talus.sk@gmail.com", new DateTime(2002, 2, 1),
                17500.0, d4);
            Seller s5 = new Seller(5, "Makoa", "challenge.makoa@gmail.com", new DateTime(1805, 7, 17),
                1750.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 15), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 17), 2000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 05), 15000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 07), 27000.0, SaleStatus.Billed, s5);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 06), 35000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 25), 10000.0, SaleStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 26), 19000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 01), 39000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 02), 42000.0, SaleStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 03), 4500.0, SaleStatus.Billed, s3);
            SalesRecord r11= new SalesRecord(11, new DateTime(2018, 09, 03), 3000.0, SaleStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 24), 70000.0, SaleStatus.Billed, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 12), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 11), 20000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 10), 50000.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 09, 30), 20000.0, SaleStatus.Billed, s5);
            SalesRecord r17= new SalesRecord(17, new DateTime(2018, 09, 13), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r18= new SalesRecord(18, new DateTime(2018, 09, 17), 1000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 09, 27), 1900.0, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 09, 22), 3900.0, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 09, 21), 42000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 09, 20), 45000.0, SaleStatus.Billed, s3);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 09, 26), 30000.0, SaleStatus.Billed, s4);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 09, 16), 7000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18,
                r19, r20, r21, r22, r23, r24);

            _context.SaveChanges();
        }
    }
}
