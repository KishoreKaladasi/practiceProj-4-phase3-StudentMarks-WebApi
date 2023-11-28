using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Phase3_PracticeProj_sec6_WEbapi_StudentMarks.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}