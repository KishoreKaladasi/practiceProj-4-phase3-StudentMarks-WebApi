using System;
using System.Reflection;

namespace Phase3_PracticeProj_sec6_WEbapi_StudentMarks.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}