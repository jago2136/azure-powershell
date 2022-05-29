
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for VirtualMachine.
.Description
Create an in-memory object for VirtualMachine.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.VirtualMachine
.Link
https://docs.microsoft.com/powershell/module/az.MLWorkspace/new-AzMLWorkspaceVirtualMachineObject
#>
function New-AzMLWorkspaceVirtualMachineObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.VirtualMachine')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The description of the Machine Learning compute.")]
        [string]
        $Description,
        [Parameter(HelpMessage="Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.")]
        [bool]
        $DisableLocalAuth,
        [Parameter(HelpMessage="ARM resource id of the underlying compute.")]
        [string]
        $ResourceId,
        [Parameter(HelpMessage="Public IP address of the virtual machine.")]
        [string]
        $Address,
        [Parameter(HelpMessage="Password of admin account.")]
        [string]
        $AdministratorAccountPassword,
        [Parameter(HelpMessage="Private key data.")]
        [string]
        $AdministratorAccountPrivateKeyData,
        [Parameter(HelpMessage="Public key data.")]
        [string]
        $AdministratorAccountPublicKeyData,
        [Parameter(HelpMessage="Username of admin account.")]
        [string]
        $AdministratorAccountUsername,
        [Parameter(HelpMessage="Indicates whether this compute will be used for running notebooks.")]
        [bool]
        $IsNotebookInstanceCompute,
        [Parameter(HelpMessage="Notebook server port open for ssh connections.")]
        [int]
        $NotebookServerPort,
        [Parameter(HelpMessage="Virtual Machine size.")]
        [string]
        $Size,
        [Parameter(HelpMessage="Port open for ssh connections.")]
        [int]
        $SshPort
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.VirtualMachine]::New()
        $Object.Type = 'VirtualMachine'

        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('DisableLocalAuth')) {
            $Object.DisableLocalAuth = $DisableLocalAuth
        }
        if ($PSBoundParameters.ContainsKey('ResourceId')) {
            $Object.ResourceId = $ResourceId
        }
        if ($PSBoundParameters.ContainsKey('Address')) {
            $Object.Address = $Address
        }
        if ($PSBoundParameters.ContainsKey('AdministratorAccountPassword')) {
            $Object.AdministratorAccountPassword = $AdministratorAccountPassword
        }
        if ($PSBoundParameters.ContainsKey('AdministratorAccountPrivateKeyData')) {
            $Object.AdministratorAccountPrivateKeyData = $AdministratorAccountPrivateKeyData
        }
        if ($PSBoundParameters.ContainsKey('AdministratorAccountPublicKeyData')) {
            $Object.AdministratorAccountPublicKeyData = $AdministratorAccountPublicKeyData
        }
        if ($PSBoundParameters.ContainsKey('AdministratorAccountUsername')) {
            $Object.AdministratorAccountUsername = $AdministratorAccountUsername
        }
        if ($PSBoundParameters.ContainsKey('IsNotebookInstanceCompute')) {
            $Object.IsNotebookInstanceCompute = $IsNotebookInstanceCompute
        }
        if ($PSBoundParameters.ContainsKey('NotebookServerPort')) {
            $Object.NotebookServerPort = $NotebookServerPort
        }
        if ($PSBoundParameters.ContainsKey('Size')) {
            $Object.Size = $Size
        }
        if ($PSBoundParameters.ContainsKey('SshPort')) {
            $Object.SshPort = $SshPort
        }
        return $Object
    }
}

