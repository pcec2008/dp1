using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.ServiceModel.Activation;
using System.Configuration;

namespace MvcApplication1.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“CsRestService”。

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class CsRestService : ICsRestService
    {
        public ResultSVM cscs()
        {
            ResultSVM svm = new ResultSVM();
            svm.Message = "haha";
            return svm;
        }
    }
}
