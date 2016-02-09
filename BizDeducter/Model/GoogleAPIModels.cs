﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BizDeducter.Model
{
	public class Distance
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("value")]
		public int ValueInMeters { get; set; }
	}

	public class Duration
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("value")]
		public int ValueInSeconds { get; set; }
	}

	public class Element
	{
		[JsonProperty("distance")]
		public Distance Distance { get; set; }
		[JsonProperty("duration")]
		public Duration Duration { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
	}

	public class Row
	{
		[JsonProperty("elements")]
		public List<Element> Elements { get; set; }
	}

	public class DistanceCalculation
	{
		[JsonProperty("destination_addresses")]
		public List<string> DestinationAddresses { get; set; }
		[JsonProperty("origin_addresses")]
		public List<string> OriginAddresses { get; set; }
		[JsonProperty("Rows")]
		public List<Row> Rows { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
