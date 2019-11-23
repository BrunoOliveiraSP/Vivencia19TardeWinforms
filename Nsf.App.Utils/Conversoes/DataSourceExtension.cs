using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public static class DataSourceExtension
    {
        public static DTO GetDTO<DTO>(this ComboBox cbo) where DTO : class, new()
        {
            DTO dto = cbo.SelectedItem as DTO;
            if (dto == null)
                return new DTO();
            return dto;
        }

        public static DTO GetDTO<DTO>(this ListBox lbx) where DTO : class, new()
        {
            DTO dto = lbx.SelectedItem as DTO;
            if (dto == null)
                return new DTO();
            return dto;
        }
        
    }
}
