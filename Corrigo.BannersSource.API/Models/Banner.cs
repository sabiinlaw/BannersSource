using System.Collections.Generic;

namespace Corrigo.BannersSource.API.Models
{
    public class Banner
    {
        public string CountryCode { get; set; }
        public int EnterpriseCompanyId { get; set; }
        public string EnterpriseCompanyName { get; set; }
        public string UiCulture { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public List<string> Trades { get; set; }
    }
}
