
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <title>Sistema de Gestão de Clientes</title>
</head>
<body>
    <div class="container">
        <h2>Sitema de Gestão de Clientes</h2>
        <hr />
        @RenderBody()
    </div>

    <script src="~/Scripts/jquery-3.0.0.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</body>
</html>
