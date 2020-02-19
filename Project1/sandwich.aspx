<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sandwich.aspx.cs" Inherits="Project1.sandwich" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!--Bootstrap-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="Style/StyleSheet.css">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans&display=swap" rel="stylesheet"> <!--Open Sans fonts-->
    <link href="https://fonts.googleapis.com/css?family=Bowlby+One+SC&display=swap" rel="stylesheet"> <!--Bowlby fonts-->
    
    <title>HANS SANDWICH</title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="header">
            <div class="hero-image">
                <div class="hero-text">
                    <h1>Hans' Sandwich</h1>
                    <h5>Get your freshest and best tasting sandwich at good prices</h5>
                </div>
            </div>
        </section>
        
        <div class ="main container">
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6 " id="contents" >
                    <asp:Label ID="lblCustomer" runat="server" ></asp:Label>

                    <asp:Label ID="lblOrder" runat="server"></asp:Label>

                    <asp:Label ID="lblTransaction" runat="server"></asp:Label>
                </div>
                <div class="col-md-3"></div>
            </div>
        </div>

        <div class="footer">
            <div id="copyright">
                <h5> &copy; HANS YIM | CIS 3342 | Temple University</h5>
            </div>
        </div>
    </form>
</body>
</html>
