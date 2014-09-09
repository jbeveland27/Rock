﻿<%@ control language="C#" autoeventwireup="true" inherits="RockWeb.Blocks.CheckIn.Manager.SelectArea, RockWeb" %>

<Rock:RockUpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>

        <div class="checkin-manager">

            <ul class="list-group">

                <asp:Repeater ID="rptNavItems" runat="server">
                    <ItemTemplate>
                        <li id="liNavItem" runat="server" class="list-group-item clickable" >
                            <asp:PlaceHolder runat="server">
                                <div><%# Eval("Name") %>
                                <i class="fa fa-chevron-right pull-right" style="margin-top: 4px;"></i></div>
                            </asp:PlaceHolder>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>

            </ul>

        </div>

    </ContentTemplate>
</Rock:RockUpdatePanel>
