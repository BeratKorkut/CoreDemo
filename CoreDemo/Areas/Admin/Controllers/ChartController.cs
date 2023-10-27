using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Sinema",
                categorycount = 2
            });


            return Json(new { jsonlist = list });
        }

    }
}

//EĞER VERİ TABANINDAN BU VERİLERİ ÇEKMEK İSTİYORSAN AŞAĞIDAKİ KODU İNCELEYEBİLİRSİN

//Sıkıntı yaşayanlar için bende çalışan şeklini not düşmek istedim öncelikle  Modelde oluşturdugunuz değişken isimlerini küçük yazın 
//ben başlık ve category id si çekmiştim  model tablomda  

//Model Kısmında ki alan 
//_____________________________________
//   public int id { get; set; }
//public string title { get; set; } 
//,_____________________________________


//bu şekilde küçük harflerle tanımladım ne önemi var demeyin gerçekten gözükmüyor  küçük harf olmayınca neyse 

//Controller tarafındaki kodlarım 
//____________________________


//public IActionResult VisualizeResult()
//{
//    return Json(BlogList());
//}



//public List<Chart> BlogList()
//{
//    List<Chart> cs = new List<Chart>();
//    using (var c = new Context())
//    {
//        cs = c.Blogs.Select(x => new Chart
//        {
//            title = x.BlogTitle,
//            id = x.CategoryID
//        }).ToList();
//    }


//    return cs;
//}



//View kısmında ki kodlar  
//__________________________

//<!DOCTYPE html>
//<html lang="en">
//<head>
//    <title>Result Visualization</title>
//    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
//    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
//    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
//    <script>
//        $(document).ready(function() {
//            $.ajax({
//    type: "POST",
//                dataType: "json",
//                contentType: "application/json",
//                url: '@Url.Action("VisualizeResult", "Charts")',
//                success: function(result) {
//            google.charts.load('current', {
//                'packages': ['corechart']
//                    });
//            google.charts.setOnLoadCallback(function() {
//                drawChart(result);
//            });
//        }
//    });
//});
//function drawChart(result)
//{
//    var data = new google.visualization.DataTable();
//    data.addColumn('string', 'Name');
//    data.addColumn('number', 'Yüzdeler');
//    var dataArray = [];
//            $.each(result, function(i, obj) {
//        dataArray.push([obj.title, obj.id]);
//    });
//data.addRows(dataArray);
//var columnChartOptions = {
//                title: "Blog Pie - Puan",
//                width: 800,
//                height: 600,
//                bar: { groupWidth: "20%" },
//            };
//var columnChart = new google.visualization.PieChart(document
//    .getElementById('Piechart_div'));
//columnChart.draw(data, columnChartOptions);
//        }
//    </ script >
//</ head >
//< body >
//    < div style = "width:150px; height:150px;" id = "Piechart_div" ></ div >
//</ body >
//</ html >
