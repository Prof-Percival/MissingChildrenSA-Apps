using MissingChildrenSA.Models;
using System.Text.Json.Serialization;

[JsonSerializable(typeof(MissingPersonModel))]
public partial class JsonContext : JsonSerializerContext
{
}