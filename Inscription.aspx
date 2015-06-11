<%@ Page Title="Inscription" Language="VB" MasterPageFile="~/PageMaster.master" AutoEventWireup="false" CodeFile="Inscription.aspx.vb" Inherits="Inscription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript" src="../Scripts/inscription.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="col-lg-12 text-center">
        <h2 class="section-heading">Inscription</h2>
        <hr class="primary">
    </div>
    <div ng-controller="inscription" class="form-group">
        <%--<label for="inputEmail3" class="col-sm-2 control-label">Nom</label>--%>
        <div class="col-md-12">
            <div class="col-md-4 col-md-offset-4">
              <input ng-model="User.Nom" type="text" class="col-md-12 form-control" id="nom" placeholder="Nom">
            </div>
        </div>
        <div class="col-md-12">
        <%--<label for="inputEmail3" class="col-sm-2 control-label">Prenom</label>--%>
            <div class="col-md-4 col-md-offset-4 m-top-lg">
              <input ng-model="User.Prenom" type="text" class="col-md-12 form-control" id="prenom" placeholder="Prenom">
            </div>
        </div>
         <div class="col-md-12">
        <%--<label for="inputEmail3" class="col-sm-2 control-label">Prenom</label>--%>
            <div class="col-md-4 col-md-offset-4 m-top-lg">
              <input ng-model="User.Email" type="email" class="col-md-12 form-control" id="email" placeholder="Email">
            </div>
        </div>
         <div class="col-md-12">
        <%--<label for="inputEmail3" class="col-sm-2 control-label">Prenom</label>--%>
            <div class="col-md-4 col-md-offset-4 m-top-lg">
              <input ng-model="User.Password" type="password" class="col-md-12 form-control" id="password" placeholder="Password">
            </div>
        </div>
         <div class="col-md-12">
            <button ng-click="valider(User);" class="col-md-4 col-md-offset-4 m-top-lg btn btn-success">Valider</button>
        </div>
        <div class="col-md-12 m-top-lg">
            <span class="col-md-4 col-md-offset-4 text-center alert alert-danger">Veuillez remplir tous les champs</span>
        </div> 
  </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" Runat="Server">
</asp:Content>

