<%@ Page Title="Home Page" Language="C#" EnableSessionState="ReadOnly" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="projectBook._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ব্যক্তিগত লাইব্রেরিতে আপনাকে স্বাগতম
            <asp:Label ID="lblUserDetails" runat="server" Text=""></asp:Label>
        </h1>
        <br />
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>নতুন বই এর তথ্য সংরক্ষণ</h2>
            <p>
                বই এর নাম, লেখক এর নাম, প্রকাশনীর নাম, প্রকাশকের নাম, দাম, বইয়ের প্রচ্ছদ এর ছবি । <br />
                নতুন বই এর তথ্য নিচের বাটনে ক্লিক করে সংরক্ষণ করুন।
            </p>
            <p>
                <a class="btn btn-success" href="bookinfoentry.aspx">সংরক্ষণ &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>বইয়ের তথ্যের তালিকা</h2>
            <p>
                বইয়ের তথ্যের তালিকা দেখুন।  <br /> 
                বই এর নাম, লেখক এর নাম, প্রকাশনীর নাম, প্রকাশকের নাম, দাম, বইয়ের প্রচ্ছদ এর ছবি ।
            </p>
            <p>
                <a class="btn btn-success" href="bookslist.aspx">তালিকা দেখুন &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>বইয়ের তথ্য খুঁজুন</h2>
            <p>
                বইয়ের তথ্য খুঁজুন। <br />
                বইয়ের নাম বা বইয়ের লেখকের নাম দিয়েন বইয়ের তথ্য খুঁজুন।<br />
                একই সাথে বইয়ের তথ্য আপডেট করুন।

            </p>
            <p>
                <a class="btn btn-success" href="searchbooks.aspx">তথ্য খুঁজুন &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
