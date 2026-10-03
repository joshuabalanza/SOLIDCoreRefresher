namespace APICalculator.DTOs;

public record SampleocpDTOs(
    decimal sampleValue1,
    decimal sampleValue2,
    string operationType
);

public record SampleocpResult(
    decimal Total
);

public record StatusDTO(
    string StatusMessage,
    int StatusCode
);