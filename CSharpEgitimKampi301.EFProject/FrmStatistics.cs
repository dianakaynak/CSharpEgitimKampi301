using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}

		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
		private void FrmStatistics_Load(object sender, EventArgs e)
		{

			lblLocationCountt.Text = db.Location.Count().ToString();
			lblSumCapacityy.Text = db.Location.Sum(x => x.Capacity).ToString();
			lblGuideCountt.Text = db.Guide.Count().ToString();

			decimal avgCapacity = decimal.Parse(db.Location.Average(x => x.Capacity).ToString());
			lblAvgCapacity.Text = avgCapacity.ToString("0.00") + " ₺";

			decimal avgLocPrice = decimal.Parse(db.Location.Average(x => x.Price).ToString());
			lblAvgLocationPrice.Text = avgLocPrice.ToString("0.00") + " ₺";

			int lastCountryId = db.Location.Max(x => x.LocationId);
			lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

			lblCappadociaLocationCapacity.Text=db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

			lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y => y.Capacity).ToString();
			var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
			lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

			var maxCapacity=db.Location.Max(x=>x.Capacity);
			lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

			var maxPrice = db.Location.Max(x => x.Price);
			lblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

			var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
lblAysegulCinarLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByNameAysegulCinar).Count().ToString();	

		}

	}
}
