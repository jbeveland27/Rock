﻿<%@ control language="C#" autoeventwireup="true" inherits="RockWeb.Blocks.Communication.CommunicationList, RockWeb" %>
<script>
    Sys.Application.add_load(function () {
        $('.grid-table span.badge').tooltip({ html: true, container: 'body', delay: { show: 500, hide: 100 } });
    });
</script>
<asp:UpdatePanel ID="upFinancial" runat="server">
    <ContentTemplate>

        <div class="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-comments-o"></i> Communication List</h1>
            </div>
            <div class="panel-body">

                <div class="grid grid-panel">
                    <Rock:GridFilter ID="rFilter" runat="server">
                        <Rock:RockTextBox ID="tbSubject" runat="server" Label="Subject" />
                        <Rock:ComponentPicker ID="cpChannel" runat="server" ContainerType="Rock.Communication.ChannelContainer, Rock" Label="Channel" />
                        <Rock:RockDropDownList ID="ddlStatus" runat="server" Label="Status" />
                        <Rock:PersonPicker ID="ppSender" runat="server" Label="Created By" />
                        <Rock:DateRangePicker ID="drpDates" runat="server" Label="Date Range" />
                        <Rock:RockTextBox ID="tbContent" runat="server" Label="Content" />
                    </Rock:GridFilter>

                    <Rock:Grid ID="gCommunication" runat="server" AllowSorting="true" OnRowSelected="gCommunication_RowSelected" OnRowDataBound="gCommunication_RowDataBound" >
                        <Columns>
                            <asp:BoundField DataField="Communication.Subject" SortExpression="Communication.Subject" HeaderText="Subject" />
                            <asp:BoundField DataField="ChannelName" SortExpression="ChannelName" HeaderText="Channel" />
                            <asp:BoundField DataField="Communication.SenderPersonAlias.Person.FullName" HeaderText="Created By"
                                SortExpression="Communication.SenderPersonAlias.Person.LastName,Communication.SenderPersonAlias.Person.NickName" />
                            <asp:BoundField DataField="Communication.ReviewerPersonAlias.Person.FullName" HeaderText="Reviewed By"
                                SortExpression="Communication.ReviewerPersonAlias.Person.LastName,Communication.ReviewerPersonAlias.Person.NickName"  />
                            <Rock:DateTimeField DataField="Communication.ReviewedDateTime" SortExpression="Communication.ReviewedDateTime" HeaderText="Date Reviewed" />
                            <Rock:EnumField DataField="Communication.Status" SortExpression="Communication.Status" HeaderText="Communication Status" />
                            <asp:TemplateField HeaderText="Recipients" ItemStyle-HorizontalAlign="Center" SortExpression="Recipients">
                                <ItemTemplate>
                                    <Rock:Badge ID="bOpened" runat="server" Tooltip="Opened" BadgeType="Success"></Rock:Badge>
                                    <Rock:Badge ID="bDelivered" runat="server" ToolTip="Delivered" BadgeType="info"></Rock:Badge>
                                    <Rock:Badge ID="bPending" runat="server" ToolTip="Pending" BadgeType="None"></Rock:Badge>
                                    <Rock:Badge ID="bCancelled" runat="server" ToolTip="Cancelled" BadgeType="Warning"></Rock:Badge>
                                    <Rock:Badge ID="bFailed" runat="server" Tooltip="Failed" BadgeType="Danger"></Rock:Badge>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <Rock:DeleteField OnClick="gCommunication_Delete" />
                        </Columns>
                    </Rock:Grid>
                </div>

            </div>
        </div>

        <Rock:ModalAlert ID="mdGridWarning" runat="server" />

        

    </ContentTemplate>
</asp:UpdatePanel>
