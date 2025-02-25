namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/capabilities/get</c></para>
/// </summary>
public partial class TransferCapabilitiesGetRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited. Required if not using <c>payment_profile_token</c>.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>A payment profile token associated with the Payment Profile data that is being requested.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string PaymentProfileToken { get; set; } = default!;
}