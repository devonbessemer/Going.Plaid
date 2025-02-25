namespace Going.Plaid.Entity;

/// <summary>
/// <para>The legal name and other information for the account holder.</para>
/// </summary>
public partial class TransferAuthorizationUserInRequest : RequestBase
{
	/// <summary>
	/// <para>The user's legal name.</para>
	/// </summary>
	[JsonPropertyName("legal_name")]
	public string LegalName { get; set; } = default!;

	/// <summary>
	/// <para>The user's phone number. In order to qualify for a guaranteed transfer, at least one of <c>phone_number</c> or <c>email_address</c> must be provided.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's email address. In order to qualify for a guaranteed transfer, at least one of <c>phone_number</c> or <c>email_address</c> must be provided.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>The address associated with the account holder. Providing this data will improve the likelihood that Plaid will be able to guarantee the transfer, if applicable.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.TransferUserAddressInRequest Address { get; set; } = default!;
}