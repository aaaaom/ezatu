using ProjectServiceEZATU.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace ProjectServiceEZATU.Service
{
    public static class Wrap
    {
        public static ObjectResult ResponseOK(object body)
        {
            return new ObjectResult(new ResponseBase
            {
                body = body
            });
        }

        public static ObjectResult ResponseOK(bool TimeExpire, object data, bool success, string message, string moduleName)
        {
            return new ObjectResult(new ResponseBase
            {

                head = new ResponseBaseHeader()
                {
                    status = 200,
                    message = message,
                    Modulename = moduleName,
                    timeexpire = TimeExpire,
                },
                body = data
            });
        }

        public static ObjectResult ResponseError(bool TimeExpire, object data, string message, int statusCode = 200, string moduleName = null)
        {
            var obj = new ObjectResult(new ResponseBase
            {
                head = new ResponseBaseHeader()
                {
                    status = statusCode,
                    message = message,
                    Modulename = moduleName,

                    timeexpire = TimeExpire,
                },
            });
            return obj;
        }

        public static ObjectResult Response(ResponseBase data)
        {
            var obj = new ObjectResult(data);
            obj.StatusCode = data.head.status;
            return obj;
        }
        public static ObjectResult ResponseGeneral(object data)
        {
            return new ObjectResult(new ResponseBase
            {
                head = new ResponseBaseHeader(),
                body = data
            });
        }


    }
}
