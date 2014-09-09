﻿<%@ control language="C#" autoeventwireup="true" inherits="RockWeb.Blocks.Groups.GroupSearch, RockWeb" %>

<div class="grid">
    <Rock:Grid ID="gGroups" runat="server" EmptyDataText="No Groups Found">
        <Columns>
            <asp:BoundField
                HeaderText="Group"
                DataField="Structure"
                SortExpression="Structure" HtmlEncode="false" />
            <asp:BoundField 
                HeaderText="Type"
                DataField="GroupType" 
                SortExpression="GroupType" />
            <asp:BoundField 
                HeaderText="Member Count"
                ItemStyle-HorizontalAlign="Right"
                DataField="MemberCount" 
                SortExpression="MemberCount"
                DataFormatString="{0:N0}" />
        </Columns>
    </Rock:Grid>
</div>


