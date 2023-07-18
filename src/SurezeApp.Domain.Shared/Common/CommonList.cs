using System;
using System.Collections.Generic;
using System.Text;

namespace SurezeApp.Common
{
    public static class CommonList
    {
        public static readonly List<CommonModel> activeStatuses = new()
        {
            new CommonModel{ Code = "active", Name = "Active" },
            new CommonModel{ Code = "Inactive", Name = "InActive" },
            new CommonModel{ Code = "InactiveDeceased", Name = "Inactive-Deceased" },
        };

        public static readonly List<CommonModel> citizenStatuses = new()
        {
            new CommonModel{ Code = "0", Name = "Yes" },
            new CommonModel{ Code = "1", Name = "No" },
        };

        public static readonly List<CommonModel> genders = new()
        {
            new CommonModel{ Code = "F", Name = "Female" },
            new CommonModel{ Code = "M", Name = "Male" },
            new CommonModel{ Code = "O", Name = "Others" },
            new CommonModel{ Code = "U", Name = "Unknown" },
        };
    }

    public class CommonModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
