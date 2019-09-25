<%@ Page Title="" Language="C#" EnableSessionState="ReadOnly" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bookinfoentry.aspx.cs" Inherits="projectBook.bookinfoentry" %>
        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div class="container">
        <h1>এই ফরমটিতে বইয়ের তথ্য দিয়ে পূরণ করুন</h1>
            <div class="form-group col-md-12">
                <asp:Label ID="Label1" runat="server" Text="বইয়ের নাম"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
              <div class="form-group col-md-12">
                <asp:Label ID="Label2" runat="server" Text="লেখকের নাম"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
              <div class="form-group col-md-12">
                <asp:Label ID="Label3" runat="server" Text="প্রকাশক নাম"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
              <div class="form-group col-md-12">
                <asp:Label ID="Label4" runat="server" Text="প্রকাশনীর নাম"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
              <div class="form-group col-md-12">
                <asp:Label ID="Label5" runat="server" Text="পাতা সংখ্যা"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
              <div class="form-group col-md-12">
                <asp:Label ID="Label6" runat="server" Text="মুদ্রিত মূল্য"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
               </div>
              <!--<div class="form-group col-md-12">
                <asp:Label ID="Label7" runat="server" Text="বইয়ের ছবি"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
              </div>-->
             <div class="form-group col-md-12">
                 <asp:Button ID="bookdatainsertbtn" CssClass="btn btn-success" runat="server" Text="সংরক্ষণ করুন" OnClick="bookdatainsertbtn_Click" />
              </div>
        </div>
    </asp:Content>

