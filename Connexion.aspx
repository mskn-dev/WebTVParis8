<%@ Page Title="Connexion" Language="VB" MasterPageFile="~/PageMaster.master" AutoEventWireup="false" CodeFile="Connexion.aspx.vb" Inherits="Connexion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="col-lg-12 text-center">
        <h2 class="section-heading">Connexion</h2>
        <hr class="primary">
    </div>
    <div class="col-md-12">
    <%--<label for="inputEmail3" class="col-sm-2 control-label">Prenom</label>--%>
        <div class="col-md-4 col-md-offset-4 m-top-lg">
            <input type="email" class="col-md-12 form-control" id="email" placeholder="Email">
        </div>
    </div>
        <div class="col-md-12">
    <%--<label for="inputEmail3" class="col-sm-2 control-label">Prenom</label>--%>
        <div class="col-md-4 col-md-offset-4 m-top-lg">
            <input type="password" class="col-md-12 form-control" id="password" placeholder="Password">
        </div>
    </div>
    <div class="col-md-12">
        <button class="col-md-4 col-md-offset-4 m-top-lg btn btn-success">Se connecter</button>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" Runat="Server">
</asp:Content>

