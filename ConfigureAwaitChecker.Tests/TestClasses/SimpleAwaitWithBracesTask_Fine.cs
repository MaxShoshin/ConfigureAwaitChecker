﻿using System.Threading.Tasks;
using ConfigureAwaitChecker.Tests.TestClasses;

public class SimpleAwaitWithBracesTask_Fine : TestClassBase
{
	public async Task FooBar()
	{
		await (Task.Delay(1)).ConfigureAwait(false);
	}
}
