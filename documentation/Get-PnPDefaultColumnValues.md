---
applicable: SharePoint Online
external help file: PnP.PowerShell.dll-Help.xml
Module Name: PnP.PowerShell
online version: https://pnp.github.io/powershell/cmdlets/get-pnpdefaultcolumnvalues
schema: 2.0.0
title: Get-PnPDefaultColumnValues
---

# Get-PnPDefaultColumnValues

## SYNOPSIS
Gets the default column values for all folders in document library

## SYNTAX

```powershell
Get-PnPDefaultColumnValues [-List] <ListPipeBind> [-Connection <PnPConnection>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets the default column values for a document library, per folder. Supports both text, people and taxonomy fields.

## EXAMPLES

## PARAMETERS

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

### -List
The ID, Name or Url of the list.

```yaml
Type: ListPipeBind
Parameter Sets: (All)

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```



## RELATED LINKS

[Microsoft 365 Patterns and Practices](https://aka.ms/m365pnp)