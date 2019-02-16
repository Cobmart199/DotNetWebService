<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspNetWebFormEmpty.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" href="#" />
    <title></title>


   <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
    
        <script type="text/javascript">
            $(document).ready(function () {
                $('#btnGetData').click(function () {

                    var param = $('#txtParam').val();
                    var ddlReq = $('#ddlReq');

                        $.ajax({
                            url: 'WebService2.asmx/GetClientData',
                            data: { optionalstr: param },
                            method: 'post',
                            dataType: 'json',
                            success: function (data) {
                                
                               // debugger;
                        ddlReq.append($('<option />', { value: -1, text: 'Select One' }));
                                $(data).each(function (index, item) {

                                    var date = new Date(parseInt(item.mydateTime.substr(6)));

                                ddlReq.append($('<option />', { value: item.dayOfWeek, text: date  }));
                        });
                    },
                    error: function (err) {
                        debugger;
                        alert("failed posted data" + err);
                    }

                        });

                    });
            });

    </script>



    <script type="text/javascript">
            $(document).ready(function () {
                $('#btnGetMethod').click(function () {

                    var param = $('#txtParam').val();
                    var ddlReq = $('#ddlWSGet');

                        $.ajax({
                            url: 'WebService2.asmx/GetClientDataWithGetMethod',
                            data: { optionalstr: param },
                            method: 'GET',
                            dataType: 'json',
                            success: function (data) {
                                
                               // debugger;
                        ddlReq.append($('<option />', { value: -1, text: 'Select One' }));
                                $(data).each(function (index, item) {

                                    var date = new Date(parseInt(item.mydateTime.substr(6)));

                                ddlReq.append($('<option />', { value: item.dayOfWeek, text: date  }));
                        });
                    },
                    error: function (err) {
                        debugger;
                        alert("failed posted data" + err);
                    }

                        });

                    });
            });

    </script>


    <script type="text/javascript">
        $(document).ready(function () {
            $('#ddlReq').on('change', function (e) {
                var selectedValue = $(this).val();
                if (selectedValue != '') {
                    alert('<dayOfWeek Node> Selection: ' + selectedValue +
                                            ' <mydateTime Node> Selection: ' + $("#ddlReq option:selected").text());
                }
            });
        });

    </script>


     <script type="text/javascript">
        $(document).ready(function () {
            $('#ddlWSGet').on('change', function (e) {
                var selectedValue = $(this).val();
                if (selectedValue != '') {
                    alert('<dayOfWeek Node> Selection: ' + selectedValue +
                                             ' <mydateTime Node> Selection: ' + $("#ddlWSGet option:selected").text());
                }
            });
        });

    </script>




</head>
<body>
    <p>
        Create a buildable/runnable web application (ASP.Net web form, c#)
    </p>

    <form id="form1" method="POST" runat="server">
        
      
          <div>
              <p>
                     Param : <input id="txtParam" type="text" style="width:100px" />
                   </p>
          </div>
  

        <div>
             <input type="button" id="btnGetData" value="Get Data-Post Method " />


        </div>

            <p>
                
               <asp:DropDownList ID="ddlReq" runat="server"   Width="562px">
                
              </asp:DropDownList>
               
            </p>


        <div>

            <p>
                <input type="button" id="btnGetMethod" value="Get Data-Get Method " />
            </p>

            <p>
                  <asp:DropDownList ID="ddlWSGet" runat="server"   Width="562px">
                
                  </asp:DropDownList>
            </p>

        </div>
    </form>



</body>
</html>
