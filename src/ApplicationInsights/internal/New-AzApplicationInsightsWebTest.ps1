
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
Creates or updates an Application Insights web test definition.
.Description
Creates or updates an Application Insights web test definition.
.Example
$geoLocation = @()
$geoLocation += New-AzApplicationInsightsWebTestGeolocationObject -Location "emea-nl-ams-azr"
$geoLocation += New-AzApplicationInsightsWebTestGeolocationObject -Location "us-ca-sjc-azr"
New-AzApplicationInsightsWebTest -ResourceGroupName azpwsh-rg-test -Name standard-pwsh01 -Location 'westus2' `
-Tag @{"hidden-link:/subscriptions/xxxxxxxxxx-xxxx-xxxxx-xxxxxxxxxxxx/resourceGroups/azpwsh-rg-test/providers/microsoft.insights/components/appinsights-portal01" = "Resource"} `
-RequestUrl "https://www.bing.com" -RequestHttpVerb "GET" -TestName 'standard-pwsh01' `
-RuleExpectedHttpStatusCode 200 -Frequency 300 -Enabled -Timeout 120 -Kind 'standard' -RetryEnabled -GeoLocation $geoLocation
.Example
$geoLocation = @()
$geoLocation += New-AzApplicationInsightsWebTestGeolocationObject -Location "emea-nl-ams-azr"
$geoLocation += New-AzApplicationInsightsWebTestGeolocationObject -Location "us-ca-sjc-azr"
New-AzApplicationInsightsWebTest -ResourceGroupName azpwsh-rg-test -Name 'pingwebtest-pwsh01' -TestName 'pingwentest-pwsh01testname' -Location 'westus2' `
-Tag @{"hidden-link:/subscriptions/xxxxxxxxxx-xxxx-xxxxx-xxxxxxxxxxxx/resourceGroups/azpwsh-rg-test/providers/microsoft.insights/components/appinsights-portal01" = "Resource"} `
-GeoLocation $geoLocation -RetryEnabled -Enabled -Frequency 300 -Timeout 90 `
-Kind 'ping' -RequestUrl 'https://cn.bing.com' -RequestParseDependent -RuleExpectedHttpStatusCode 200 `
-ContentMatch "status"
.Example
$geoLocation = @()
$geoLocation += New-AzApplicationInsightsWebTestGeolocationObject -Location "emea-nl-ams-azr"
$geoLocation += New-AzApplicationInsightsWebTestGeolocationObject -Location "us-ca-sjc-azr"
New-AzApplicationInsightsWebTest -ResourceGroupName azpwsh-rg-test -Name 'pingwebtest-pwsh01' -TestName 'pingwentest-pwsh01testname' -Location 'westus2' `
-Tag @{"hidden-link:/subscriptions/xxxxxxxxxx-xxxx-xxxxx-xxxxxxxxxxxx/resourceGroups/azpwsh-rg-test/providers/microsoft.insights/components/appinsights-portal01" = "Resource"} `
-GeoLocation $geoLocation -RetryEnabled -Enabled -Frequency 300 -Timeout 90 `
-Kind 'ping' `
-Configuration "<WebTest  Name=`"basic-portal03`"  Id=`"9407db10-5d84-487f-98a3-a1ee67bb98f0`"  Enabled=`"True`"  CssProjectStructure=`"`"  CssIteration=`"`"  Timeout=`"90`"  WorkItemIds=`"`"  xmlns=`"http://microsoft.com/schemas/VisualStudio/TeamTest/2010`"  Description=`"`"  CredentialUserName=`"`"  CredentialPassword=`"`"  PreAuthenticate=`"True`"  Proxy=`"default`"  StopOnError=`"False`"  RecordedResultFile=`"`"  ResultsLocale=`"`"> 
    <Items> 
        <Request Method=`"GET`"  Guid=`"a2025e53-0702-d03e-f311-5774ec16893d`"  Version=`"1.1`"  Url=`"https://www.bing.com`"  ThinkTime=`"0`"  Timeout=`"90`"  ParseDependentRequests=`"True`"  FollowRedirects=`"True`"  RecordResult=`"True`"  Cache=`"False`"  ResponseTimeGoal=`"0`"  Encoding=`"utf-8`"  ExpectedHttpStatusCode=`"200`"  ExpectedResponseUrl=`"`"  ReportingName=`"`"  IgnoreHttpStatusCode=`"False`" /> 
    </Items> 
    <ValidationRules> 
        <ValidationRule  Classname=`"Microsoft.VisualStudio.TestTools.WebTesting.Rules.ValidationRuleFindText, Microsoft.VisualStudio.QualityTools.WebTestFramework, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`"  DisplayName=`"Find Text`"  Description=`"Verifies the existence of the specified text in the response.`"  Level=`"High`"  ExectuionOrder=`"BeforeDependents`">
            <RuleParameters> 
            <RuleParameter Name=`"FindText`" Value=`"test&#x20;content&#x20;match`" /> 
            <RuleParameter Name=`"IgnoreCase`" Value=`"False`" /> 
            <RuleParameter Name=`"UseRegularExpression`" Value=`"False`" /> 
            <RuleParameter Name=`"PassIfTextFound`" Value=`"True`" /> 
            </RuleParameters> 
        </ValidationRule> 
    </ValidationRules> 
</WebTest>"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTest
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

GEOLOCATION <IWebTestGeolocation[]>: A list of where to physically run the tests from to give global coverage for accessibility of your application.
  [Location <String>]: Location ID for the WebTest to run from.

REQUESTHEADER <IHeaderField[]>: List of headers and their values to add to the WebTest call.
  [Name <String>]: The name of the header.
  [Value <String>]: The value of the header.
.Link
https://docs.microsoft.com/powershell/module/az.applicationinsights/new-azapplicationinsightswebtest
#>
function New-AzApplicationInsightsWebTest {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTest])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('WebTestName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [System.String]
    # The name of the Application Insights WebTest resource.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # The XML specification of a WebTest to run against an application.
    ${Configuration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # When set, this value makes the ContentMatch validation case insensitive.
    ${ContentIgnoreCase},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Content to look for in the return of the WebTest.
    # Must not be null or empty.
    ${ContentMatch},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # When true, validation will pass if there is a match for the ContentMatch string.
    # If false, validation will fail if there is a match
    ${ContentPassIfTextFound},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # User defined description for this WebTest.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Is the test actively being monitored.
    ${Enabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Int32]
    # Interval in seconds between test runs for this WebTest.
    # Default value is 300.
    ${Frequency},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestGeolocation[]]
    # A list of where to physically run the tests from to give global coverage for accessibility of your application.
    # To construct, see NOTES section for GEOLOCATION properties and create a hash table.
    ${GeoLocation},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum]
    # The kind of web test this is, valid choices are ping, multistep, and standard.
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Base64 encoded string body to send with this web test.
    ${RequestBody},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Follow redirects for this web test.
    ${RequestFollowRedirect},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderField[]]
    # List of headers and their values to add to the WebTest call.
    # To construct, see NOTES section for REQUESTHEADER properties and create a hash table.
    ${RequestHeader},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Http verb to use for this web test.
    ${RequestHttpVerb},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Parse Dependent request for this WebTest.
    ${RequestParseDependent},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Url location to test.
    ${RequestUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Allow for retries should this WebTest fail.
    ${RetryEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Int32]
    # Validate that the WebTest returns the http status code provided.
    ${RuleExpectedHttpStatusCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # When set, validation will ignore the status code.
    ${RuleIgnoreHttpsStatusCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Int32]
    # A number of days to check still remain before the the existing SSL cert expires.
    # Value must be positive and the SSLCheck must be set to true.
    ${RuleSslCertRemainingLifetimeCheck},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Checks to see if the SSL cert is still valid.
    ${RuleSslCheck},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebtestsResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # User defined name if this WebTest.
    ${TestName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.Int32]
    # Seconds until this WebTest will timeout and fail.
    # Default value is 30.
    ${Timeout},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateExpanded = 'Az.ApplicationInsights.private\New-AzApplicationInsightsWebTest_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
