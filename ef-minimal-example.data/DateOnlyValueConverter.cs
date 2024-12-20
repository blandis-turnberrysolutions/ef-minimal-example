
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ef_minimal_example.data;

public class DateOnlyValueConverter : ValueConverter<DateOnly, DateTime>
{
  public DateOnlyValueConverter() : base(
    dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
    dateTime => DateOnly.FromDateTime(dateTime)
  )
  { }
}