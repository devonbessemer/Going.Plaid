namespace Going.Plaid.Entity;

/// <summary>
/// <para>A grouping of related transactions</para>
/// </summary>
public record TransactionStream
{
	/// <summary>
	/// <para>The ID of the account to which the stream belongs</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>A unique id for the stream</para>
	/// </summary>
	[JsonPropertyName("stream_id")]
	public string StreamId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the category to which this transaction belongs. See <a href="https://plaid.com/docs/#category-overview">Categories</a>.</para>
	/// </summary>
	[JsonPropertyName("category_id")]
	public string CategoryId { get; init; } = default!;

	/// <summary>
	/// <para>A hierarchical array of the categories to which this transaction belongs. See <a href="https://plaid.com/docs/#category-overview">Categories</a>.</para>
	/// </summary>
	[JsonPropertyName("category")]
	public IReadOnlyList<string> Category { get; init; } = default!;

	/// <summary>
	/// <para>A description of the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The merchant associated with the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string? MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>The posted date of the earliest transaction in the stream.</para>
	/// </summary>
	[JsonPropertyName("first_date")]
	public DateOnly FirstDate { get; init; } = default!;

	/// <summary>
	/// <para>The posted date of the latest transaction in the stream.</para>
	/// </summary>
	[JsonPropertyName("last_date")]
	public DateOnly LastDate { get; init; } = default!;

	/// <summary>
	/// <para>Describes the frequency of the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("frequency")]
	public Entity.RecurringTransactionFrequency Frequency { get; init; } = default!;

	/// <summary>
	/// <para>An array of Plaid transaction IDs belonging to the stream, sorted by posted date.</para>
	/// </summary>
	[JsonPropertyName("transaction_ids")]
	public IReadOnlyList<string> TransactionIds { get; init; } = default!;

	/// <summary>
	/// <para>Object with data pertaining to an amount on the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("average_amount")]
	public Entity.TransactionStreamAmount AverageAmount { get; init; } = default!;

	/// <summary>
	/// <para>Object with data pertaining to an amount on the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("last_amount")]
	public Entity.TransactionStreamAmount LastAmount { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the transaction stream is still live.</para>
	/// </summary>
	[JsonPropertyName("is_active")]
	public bool IsActive { get; init; } = default!;

	/// <summary>
	/// <para>The current status of the transaction stream.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransactionStreamStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category")]
	public Entity.PersonalFinanceCategory? PersonalFinanceCategory { get; init; } = default!;
}