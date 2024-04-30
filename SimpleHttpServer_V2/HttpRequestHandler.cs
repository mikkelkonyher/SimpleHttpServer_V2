namespace SimpleHttpServer
{
    class HttpRequestHandler
    {
        public string HandleRequest(string request)
        {
            // Check if the request is empty
            if (string.IsNullOrEmpty(request))
                return "HTTP/1.1 400 Bad Request\r\n\r\nEmpty request.";

            // Split the request into tokens
            string[] tokens = request.Split(' ');
            // Check if the request method is GET
            if (tokens.Length < 2 || tokens[0] != "GET")
                return "HTTP/1.1 400 Bad Request\r\n\r\nInvalid request method.";

            // Extract the URI from the request
            string uri = tokens[1];
            string[] uriParts = uri.Split('?');  //serves as a separator between the path and the query string
            // If the URI does not contain query parameters, return an HTML form
            if (uriParts.Length < 2)
                return GetHtmlForm();

            // Parse the query parameters
            string[] parameters = uriParts[1].Split('&');
            string num1 = "", num2 = "", operation = "";
            foreach (var parameter in parameters)
            {
                string[] keyValue = parameter.Split('=');
                if (keyValue.Length == 2)
                {
                    string key = keyValue[0];
                    string value = keyValue[1];

                    // Check the key and assign the value 
                    switch (key)
                    {
                        case "num1":
                            num1 = value;
                            break;
                        case "num2":
                            num2 = value;
                            break;
                        case "operation":
                            operation = value;
                            break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2) && !string.IsNullOrEmpty(operation))
            {
                if (operation == "Add")
                {
                    double addOperator = double.Parse(num1) + double.Parse(num2);
                    return $"<html><body>The sum of {num1} and {num2} is: {addOperator}</body></html>";
                }
                else if (operation == "Multiply")
                {
                    double multiplyOperator = double.Parse(num1) * double.Parse(num2);
                    return $"<html><body>The multiplication of {num1} and {num2} is: {multiplyOperator}</body></html>";
                }
                else
                {
                    return "<html><body>Invalid operation</body></html>";
                }
            }
            else
            {
                return "<html><body>Invalid parameters</body></html>";
            }
        }

        // Method to generate an HTML form for inputting numbers
        static string GetHtmlForm()
        {
            return @"
        <html>
        <body>
        <form method='get'>
                                Number 1: <input type='number' step='any' name='num1'><br>
                                Number 2: <input type='number' step='any' name='num2'><br>
        <input type='submit' name='operation' value='Add'>
        <input type='submit' name='operation' value='Multiply'>
        </form>
        </body>
        </html>";
        }
    }
}

