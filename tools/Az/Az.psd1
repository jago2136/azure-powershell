#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 4/18/2022
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '7.5.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://docs.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.7.6'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '3.1.3'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '2.3.2'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.7.3'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.2.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.8.3'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.11.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '4.26.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '2.2.3'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.16.6'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.11.1'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.0.2'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '5.0.1'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '1.3.2'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.4'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '4.3.1'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '4.16.1'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '5.3.1'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '5.5.0'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.8.1'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.0.2'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '3.8.0'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '4.5.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.11.1'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '7.5.0 - April 2022
Az.Accounts
* Upgraded Microsoft.Rest.ClientRuntime to 2.3.24

Az.Aks
* Updated the decsription of ''Force'' in ''Invoke-AzAksRunCommand'' [#17756]
* Fixed the issue that ''identity'' cannot be piped into ''Set-AzAksCluster'' [#17376]

Az.ApiManagement
Added warning message for upcoming breaking change.

Az.Batch
* Updated Az.Batch to use ''Microsoft.Azure.Batch'' SDK version 15.3.0
  - Add ability to assign user-assigned managed identities to ''PSCloudPool''. These identities will be made available on each node in the pool, and can be used to access various resources.
  - Added ''IdentityReference'' property to the following models to support accessing resources via managed identity:
    - ''PSAzureBlobFileSystemConfiguration''
    - ''PSOutputFileBlobContainerDestination''
    - ''PSContainerRegistry''
    - ''PSResourceFile''
    - ''PSUploadBatchServiceLogsConfiguration''
  - Added new ''extensions'' property to ''PSVirtualMachineConfiguration'' on ''PSCloudPool'' to specify virtual machine extensions for nodes
  - Added the ability to specify availability zones using a new property ''NodePlacementConfiguration'' on ''VirtualMachineConfiguration''
  - Added new ''OSDisk'' property to ''VirtualMachineConfiguration'', which contains settings for the operating system disk of the Virtual Machine.
    - The ''Placement'' property on ''PSDiffDiskSettings'' specifies the ephemeral disk placement for operating system disks for all VMs in the pool. Setting it to ''CacheDisk'' will store the ephemeral OS disk on the VM cache.
  - Added ''MaxParallelTasks'' property on ''PSCloudJob'' to control the maximum allowed tasks per job (defaults to -1, meaning unlimited).
  - Added ''VirtualMachineInfo'' property on ''PSComputeNode'' which contains information about the current state of the virtual machine, including the exact version of the marketplace image the VM is using.
  - Added ''RecurrenceInterval'' property to ''PSSchedule'' to control the interval between the start times of two successive job under a job schedule.
  - Added a new ''Get-AzBatchComputeNodeExtension'' command, which gets a specific extension by name, or a list of all extensions, for a given compute node.
* Updated Az.Batch''Microsoft.Azure.Management.Batch'' SDK version 14.0.0.
  - Added a new ''Get-AzBatchSupportedVirtualMachineSku'' command, which gets the list of Batch-supported Virtual Machine VM sizes available at a given location.
  - Added a new ''Get-AzBatchTaskSlotCount'' command, which gets the number of task slots required by a given job.
  - ''MaxTasksPerComputeNode'' has been renamed to ''TaskSlotsPerNode'', to match a change in functionality.
    - ''MaxTasksPerComputeNode'' will remain as an alias but will be removed in a coming update.

Az.Cdn
* Added breaking change messages for all cmdlets in Az.CDN module

Az.CognitiveServices
* Updated CognitiveServices PowerShell to use 2022-03-01 version.
* Added ''Get-AzCognitiveServicesAccountModel'' cmdlet.

Az.Compute
* Added ''-ImageReferenceId'' parameter to following cmdlets: ''New-AzVm'', ''New-AzVmConfig'', ''New-AzVmss'', ''Set-AzVmssStorageProfile''
* Added functionality for cross-tenant image reference for VM, VMSS, Managed Disk, and Gallery Image Version creation. 
* ''New-AzGallery'' can take in ''-Permission'' parameter to set its sharingProfile property.
* ''Update-AzGallery'' can update sharingProfile.
* ''Get-AzGallery'' can take in ''-Expand'' parameter for expanded resource view.
* New parameter set for the following cmdlets to support Shared Image Gallery Direct Sharing
    - Get-AzGallery
    - Get-AzGalleryImageDefinition
    - Get-AzGalleryImageVersion
* Updates and improvements to ''Add-AzVhd''
    - Added ''-DiskHyperVGeneration'' and ''-DiskOsType'' parameters to the DirectUploadToManagedDisk parameter set for upload to more robust managed disk settings.
    - Updated progress output functions so that it works with VHD files with ''&'' character in its name.
    - Updated so that uploading dynamically sized VHD files are converted to fixed size during upload.
    - Fixed a bug in uploading a differencing disk.
    - Automically delete converted/resized VHD files after upload.
    - Fixed a bug that indicates ''-ResourceGroupName'' parameter as optional when it is actually mandatory.

Az.DataFactory
* Updated ADF .Net SDK version to 6.0.0

Az.EventHub
* Deprecating older MSI related fields in New-AzEventHubNamespace and Set-AzEventHubNamespace

Az.Kusto
* Supported inline script resource (creation of script with content instead of sas token)
* Added managed identity support to EventGrid
* Added databaseRouting (Single/Multi) to all data connections
* Added PublicIPType to cluster

Az.Network
* Fixed ''ArgumentNullException'' in ''Add-AzureRmRouteConfig'' when ''RouteTable.Routes'' is null.

Az.RecoveryServices
* Added support for multiple backups per day (hourly) Enhanced policy for workloadType AzureVM.

Az.StackHCI
* Updated firewall rules for Attestation network to block all other traffic
* Updated cluster to ignore Attestation network

Az.Storage
* Supported DaysAfterLastTierChangeGreaterThan in Management Policy
    -  ''Add-AzStorageAccountManagementPolicyAction''
* Fixed the issue that upload blob might fail on Linux [#17743]
    -  ''Set-AzStorageBlobContent''

Az.Synapse
* Added support for Synapse Azure Active Directory (Azure AD) only authentication
    - Added ''Get-AzSynapseActiveDirectoryOnlyAuthentication'' cmdlet
    - Added ''Enable-AzSynapseActiveDirectoryOnlyAuthentication'' cmdlet
    - Added ''Disable-AzSynapseActiveDirectoryOnlyAuthentication'' cmdlet

Az.Websites
* Updated ''New-AzWebAppContainerPSSession'' with CmdletDeprecation Attribute [#16646]
* Updated ''Restore-AzDeletedWebApp'' to fix issue that prevents the cmdlet from working on hosts with a locale is anything different from ''en-US''
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

