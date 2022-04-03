using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            // base de dados já contém dados
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) 
                return;

            var d1 = new Department(id: 1, name: "Computers");
            var d2 = new Department(id: 2, name: "Electronics");
            var d3 = new Department(id: 3, name: "Fashion");
            var d4 = new Department(id: 4, name: "Books");

            var s1 = new Seller(id: 1, name: "Bob Brown", email: "bob@gmail.com", birthDate: new DateTime(1998, 4, 1), baseSalary: 1000.0, department: d1);
            var s2 = new Seller(id: 2, name: "Maria Green", email: "maria@gmail.com", birthDate: new DateTime(1979, 12, 31), baseSalary: 3500.0, department: d2);
            var s3 = new Seller(id: 3, name: "Alex Grey", email: "alex@gmail.com", birthDate: new DateTime(1988, 1, 15), baseSalary: 2200.0, department: d1);
            var s4 = new Seller(id: 4, name: "Martha Red", email: "martha@gmail.com", birthDate: new DateTime(1993, 11, 30), baseSalary: 3000.0, department: d4);
            var s5 = new Seller(id: 5, name: "Donald Blue", email: "donald@gmail.com", birthDate: new DateTime(2000, 1, 9), baseSalary: 4000.0, department: d3);
            var s6 = new Seller(id: 6, name: "Alex Pink", email: "alexPink@gmail.com", birthDate: new DateTime(1997, 3, 4), baseSalary: 3000.0, department: d2);

            var r1 = new SalesRecord(id: 1, date: new DateTime(2018, 09, 25), amount: 11000.0, status: SaleStatus.Billed, seller: s1);
            var r2 = new SalesRecord(id: 2, date: new DateTime(2018, 09, 4), amount: 7000.0, status: SaleStatus.Billed, seller: s5);
            var r3 = new SalesRecord(id: 3, date: new DateTime(2018, 09, 13), amount: 4000.0, status: SaleStatus.Canceled, seller: s4);
            var r4 = new SalesRecord(id: 4, date: new DateTime(2018, 09, 1), amount: 8000.0, status: SaleStatus.Billed, seller: s1);
            var r5 = new SalesRecord(id: 5, date: new DateTime(2018, 09, 21), amount: 3000.0, status: SaleStatus.Billed, seller: s3);
            var r6 = new SalesRecord(id: 6, date: new DateTime(2018, 09, 15), amount: 2000.0, status: SaleStatus.Billed, seller: s1);
            var r7 = new SalesRecord(id: 7, date: new DateTime(2018, 09, 28), amount: 13000.0, status: SaleStatus.Billed, seller: s2);
            var r8 = new SalesRecord(id: 8, date: new DateTime(2018, 09, 11), amount: 4000.0, status: SaleStatus.Billed, seller: s4);
            var r9 = new SalesRecord(id: 9, date: new DateTime(2018, 09, 14), amount: 11000.0, status: SaleStatus.Pending, seller: s6);
            var r10 = new SalesRecord(id: 10,date: new DateTime(2018, 09, 7), amount: 9000.0, status: SaleStatus.Billed, seller: s6);
            var r11 = new SalesRecord(id: 11,date: new DateTime(2018, 09, 13), amount: 6000.0, status: SaleStatus.Billed, seller: s2);
            var r12 = new SalesRecord(id: 12,date: new DateTime(2018, 09, 25), amount: 7000.0, status: SaleStatus.Pending, seller: s3);
            var r13 = new SalesRecord(id: 13,date: new DateTime(2018, 09, 29), amount: 10000.0, status: SaleStatus.Billed, seller: s4);
            var r14 = new SalesRecord(id: 14,date: new DateTime(2018, 09, 4), amount: 3000.0, status: SaleStatus.Billed, seller: s5);
            var r15 = new SalesRecord(id: 15,date: new DateTime(2018, 09, 12), amount: 4000.0, status: SaleStatus.Billed, seller: s1);
            var r16 = new SalesRecord(id: 16,date: new DateTime(2018, 10, 5), amount: 2000.0, status: SaleStatus.Billed, seller: s4);
            var r17 = new SalesRecord(id: 17,date: new DateTime(2018, 10, 1), amount: 12000.0, status: SaleStatus.Billed, seller: s1);
            var r18 = new SalesRecord(id: 18,date: new DateTime(2018, 10, 24), amount: 6000.0, status: SaleStatus.Billed, seller: s3);
            var r19 = new SalesRecord(id: 19,date: new DateTime(2018, 10, 22), amount: 8000.0, status: SaleStatus.Billed, seller: s5);
            var r20 = new SalesRecord(id: 20,date: new DateTime(2018, 10, 15), amount: 8000.0, status: SaleStatus.Billed, seller: s6);
            var r21 = new SalesRecord(id: 21,date: new DateTime(2018, 10, 17), amount: 9000.0, status: SaleStatus.Billed, seller: s2);
            var r22 = new SalesRecord(id: 22,date: new DateTime(2018, 10, 24), amount: 4000.0, status: SaleStatus.Billed, seller: s4);
            var r23 = new SalesRecord(id: 23,date: new DateTime(2018, 10, 19), amount: 11000.0, status: SaleStatus.Canceled, seller: s2);
            var r24 = new SalesRecord(id: 24,date: new DateTime(2018, 10, 12), amount: 8000.0, status: SaleStatus.Billed, seller: s5);
            var r25 = new SalesRecord(id: 25,date: new DateTime(2018, 10, 31), amount: 7000.0, status: SaleStatus.Billed, seller: s3);
            var r26 = new SalesRecord(id: 26,date: new DateTime(2018, 10, 6), amount: 5000.0, status: SaleStatus.Billed, seller: s4);
            var r27 = new SalesRecord(id: 27,date: new DateTime(2018, 10, 13), amount: 9000.0, status: SaleStatus.Pending, seller: s1);
            var r28 = new SalesRecord(id: 28,date: new DateTime(2018, 10, 7), amount: 4000.0, status: SaleStatus.Billed, seller: s3);
            var r29 = new SalesRecord(id: 29,date: new DateTime(2018, 10, 23), amount: 12000.0, status: SaleStatus.Billed, seller: s5);
            var r30 = new SalesRecord(id: 30,date: new DateTime(2018, 10, 12), amount: 5000.0, status: SaleStatus.Billed, seller: s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s4, s5, s6);
            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
