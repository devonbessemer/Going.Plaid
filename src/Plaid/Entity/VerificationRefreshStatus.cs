namespace Going.Plaid.Entity;

/// <summary>
/// <para>The verification refresh status. One of the following:</para>
/// </summary>
public enum VerificationRefreshStatus
{
	/// <summary>
	/// <para>User presence is required to refresh an income verification.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED")]
	VerificationRefreshStatusUserPresenceRequired,

	/// <summary>
	/// <para>The income verification refresh was successful.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_REFRESH_SUCCESSFUL")]
	VerificationRefreshSuccessful,

	/// <summary>
	/// <para>No new data was found after the income verification refresh.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_REFRESH_NOT_FOUND")]
	VerificationRefreshNotFound,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}