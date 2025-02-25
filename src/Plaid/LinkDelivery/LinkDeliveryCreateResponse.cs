namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryCreateResponse defines the response schema for <c>/link_delivery/create</c></para>
/// </summary>
public record LinkDeliveryCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The URL to the Link Delivery session, which will be delivered by the specified delivery method.</para>
	/// </summary>
	[JsonPropertyName("link_delivery_url")]
	public string LinkDeliveryUrl { get; init; } = default!;

	/// <summary>
	/// <para>The ID for the link delivery session. Same as the link token string excluding the "link-{env}-" prefix</para>
	/// </summary>
	[JsonPropertyName("link_delivery_session_id")]
	public string LinkDeliverySessionId { get; init; } = default!;
}