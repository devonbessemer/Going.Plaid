namespace Going.Plaid.Entity;

/// <summary>
/// <para>PaymentInitiationRecipient defines a payment initiation recipient</para>
/// </summary>
public record PaymentInitiationRecipient
{
	/// <summary>
	/// <para>The ID of the recipient.</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the recipient.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The optional address of the payment recipient.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the recipient.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; init; } = default!;

	/// <summary>
	/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; init; } = default!;
}