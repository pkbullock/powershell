---
applicable: SharePoint Online
external help file: PnP.PowerShell.dll-Help.xml
Module Name: PnP.PowerShell
online version: https://pnp.github.io/powershell/cmdlets/get-pnpproperty
schema: 2.0.0
title: Get-PnPProperty
---

# Get-PnPProperty

## SYNOPSIS
Returns a previously not loaded property of a ClientObject

## SYNTAX

```powershell
Get-PnPProperty [-ClientObject] <ClientObject> [-Property] <String[]> [-Connection <PnPConnection>]
 [<CommonParameters>]
```

## DESCRIPTION
Will populate properties of an object and optionally, if needed, load the value from the server. If one property is specified its value will be returned to the output.

## EXAMPLES

### EXAMPLE 1
```powershell
$web = Get-PnPWeb
Get-PnPProperty -ClientObject $web -Property Id, Lists
$web.Lists
```

Will load both the Id and Lists properties of the specified Web object.

### EXAMPLE 2
```powershell
$list = Get-PnPList -Identity 'Site Assets'
Get-PnPProperty -ClientObject $list -Property Views
```

Will load the views object of the specified list object and return its value to the output.

## PARAMETERS

### -ClientObject
Specifies the object where the properties of should be retrieved

```yaml
Type: ClientObject
Parameter Sets: (All)

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Connection
Optional connection to be used by the cmdlet. Retrieve the value for this parameter by either specifying -ReturnConnection on Connect-PnPOnline or by executing Get-PnPConnection.

```yaml
Type: PnPConnection
Parameter Sets: (All)

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
The properties to load. If one property is specified its value will be returned to the output.

```yaml
Type: String[]
Parameter Sets: (All)

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## RELATED LINKS

[Microsoft 365 Patterns and Practices](https://aka.ms/m365pnp)