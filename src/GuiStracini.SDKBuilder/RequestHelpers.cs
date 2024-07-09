- url += "/?" + param;
 var separator = url.Contains("?") ? "&" : "?";
 if (!string.IsNullOrEmpty(param))
     url += separator + param;