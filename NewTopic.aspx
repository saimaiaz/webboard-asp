<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewTopic.aspx.cs" Inherits="NewTopic" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="example" class="k-content">
        <div id="tickets">
            <h3>หัวข้อใหม่</h3>
            <ul>
                <li>
                    <label for="fullname" class="required">ชื่อกระทู้</label>
                    <input type="text" id="fullname" name="fullname" class="k-textbox" placeholder="Full name" required validationMessage="Please enter {0}" />
                </li>
                <li>
                    <label for="search" class="required">รายละเอียด</label>
                    <asp:TextBox ID="TextBox1" class="k-textbox" required placeholder="ใส่รายละเอียดกระทู้" Rows="10" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <span class="k-invalid-msg" data-for="search"></span>
                </li>
                
                <li>
                    <label for="email" class="required">Email</label>
                    <input type="email" id="email" name="Email" class="k-textbox" placeholder="e.g. myname@example.net"  required data-email-msg="Email format is not valid" />
                </li>
                
                    <li  class="accept">
                    <input type="checkbox" name="Accept" required validationMessage="Acceptance is required" /> I accept the terms and condition of service
                </li>

                <li  class="accept">
                    <button class="k-button" type="submit">Submit</button>
                </li>
                <li class="status">
                </li>
            </ul>
        </div>
        </div>
        <script>
                $(document).ready(function() {
                    var data = [
                    "12 Angry Men",
                    "Il buono, il brutto, il cattivo.",
                    "Inception",
                    "One Flew Over the Cuckoo's Nest",
                    "Pulp Fiction",
                    "Schindler's List",
                    "The Dark Knight",
                    "The Godfather",
                    "The Godfather: Part II",
                    "The Shawshank Redemption"
                    ];

                    $("#search").kendoAutoComplete({
                        dataSource: data,
                        separator: ", "
                    });

                    var validator = $("#tickets").kendoValidator().data("kendoValidator"),
                    status = $(".status");

                    $("button").click(function() {
                        if (validator.validate()) {
                            status.text("Hooray! Your tickets has been booked!").addClass("valid");
                            } else {
                            status.text("Oops! There is invalid data in the form.").addClass("invalid");
                        }
                    });
                });
            </script>
            
            
            <style scoped>

                .k-textbox {
                    width: 11.8em;
                }

                #tickets {
                    width: 510px;
                    height: 323px;
                    /*margin: 30px auto;
                     padding: 10px 20px 20px 170px; */

                }

                #tickets h3 {
                    font-weight: normal;
                    font-size: 1.4em;
                    border-bottom: 1px solid #ccc;
                }

                #tickets ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                }
                #tickets li {
                    margin: 10px 0 0 0;
                }

                label {
                    display: inline-block;
                    width: 90px;
                    text-align: right;
                }

                .required {
                    font-weight: bold;
                }

                .accept, .status {
                    padding-left: 90px;
                }

                .valid {
                    color: green;
                }

                .invalid {
                    color: red;
                }
                span.k-tooltip {
                    margin-left: 6px;
                }
            </style>

</asp:Content>

