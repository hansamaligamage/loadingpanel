This sample code demonstrates how to show a simple loading panel until a long running action completes. This code sample is implememnted using ASP.NET Core and Jquery on Visual Studio 2017 with .NET Core 2.0

It has used a div tag as a loading panel and showed it when the action method starts, after data loads succesfully it hides the loading panel

Read this article to find how to add a Jquery loading panel, https://social.technet.microsoft.com/wiki/contents/articles/46671.asp-net-core-how-to-show-a-loading-panel-in-a-page.aspx

This code snippet shows how to show a loading panel in middle of a long running action, If you want to style this loading panel you can use bootstrap styling or any other technique


<code> 
   
    <script>
            $(function () { 
 
                $('#loaddata').click(function () { 
 
                    $('#loading-div-background').show(); 
 
                    Promise.resolve($.ajax({ 
                        type: "GET", 
                        url: '/Home/GetData', 
                        contentType: false, 
                        processData: false 
                    })).then(function (result) { 
                        if (result) { 
                            $('#loading-div-background').hide(); 
                            $("#tableheader").show() 
                            var row = ""; 
                            $.each(result, function (index, item) { 
                                row += "<tr><td><input type='checkbox'id='chk_" 
                                    + item + "'/></td><td>" + item + "</td><td>" 
                                    + item + "</td><td>" + item + "</td><td>" + item 
                                    + "</td><td>" + item + "</td></tr> "; 
                            }); 
                            $("#tablebody").html(row); 
                        } 
                    }).catch(function (e) { 
                        console.log(e); 
                    }); 
                }); 
 
            }); 
        </script>
</code>
