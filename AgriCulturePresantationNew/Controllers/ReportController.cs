using AgriCulturePresantationNew.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart.ChartEx;

namespace AgriCulturePresantationNew.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {
            ExcelPackage.License.SetNonCommercialPersonal("Ekrem Arslan");
            ExcelPackage excelPackage = new ExcelPackage();

            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Katagorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "785 Kg";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "1.986 Kg";

            workBook.Cells[4, 1].Value = "Havuç";
            workBook.Cells[4, 2].Value = "Sebze";
            workBook.Cells[4, 3].Value = "167 Kg";

            var bytes = excelPackage.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BakliyatRaporu.xlsx");
        }

        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgriCultureContext())
            {
                contactModels = context.Contacts.Select(x => new ContactModel
                {
                    ContactID = x.ContactID,
                    ContactName = x.Name,
                    ContactMail = x.Mail,
                    Message = x.Message,
                    ContactDate = x.Date
                }).ToList();
            }
            return contactModels;

        }

        public IActionResult ContactReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Contact Report");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Name";
                workSheet.Cell(1, 3).Value = " Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";
                int ContactRowCount = 2;
                foreach (var item in ContactList())
                {
                    workSheet.Cell(ContactRowCount, 1).Value = item.ContactID;
                    workSheet.Cell(ContactRowCount, 2).Value = item.ContactName;
                    workSheet.Cell(ContactRowCount, 3).Value = item.ContactMail;
                    workSheet.Cell(ContactRowCount, 4).Value = item.Message;
                    workSheet.Cell(ContactRowCount, 5).Value = item.ContactDate;
                    ContactRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MesajReport.xlsx");
                }
              
            }



        }

        public List<AnnouncemetModel> AnnouncementList()
        {
            List<AnnouncemetModel> AnnouncementModels = new List<AnnouncemetModel>();
            using (var context = new AgriCultureContext())
            {
                AnnouncementModels = context.Announcements.Select(x => new AnnouncemetModel
                {
                  ID = x.AnnouncementID,
                  Status = x.Status,
                  Date = x.Date,
                    Description = x.Description,
                    Title = x.Title
                }).ToList();
            }
            return AnnouncementModels;

        }
        public IActionResult AnnoucementReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Announcement Report");
                workSheet.Cell(1, 1).Value = "Duyuru ID";
                workSheet.Cell(1, 2).Value = "Duyuru BAŞLIĞI";
                workSheet.Cell(1, 3).Value = " Duyuru Tarihi";
                workSheet.Cell(1, 4).Value = "Duyuru İçeriği";
                workSheet.Cell(1, 5).Value = "Durum";
                int ContactRowCount = 2;
                foreach (var item in  AnnouncementList())
                {
                    workSheet.Cell(ContactRowCount, 1).Value = item.ID;
                    workSheet.Cell(ContactRowCount, 2).Value = item.Title;
                    workSheet.Cell(ContactRowCount, 3).Value = item.Date;
                    workSheet.Cell(ContactRowCount, 4).Value = item.Description;
                    workSheet.Cell(ContactRowCount, 5).Value = item.Status;
                    ContactRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DuyuruReport.xlsx");
                }

            }



        }

    }
}
