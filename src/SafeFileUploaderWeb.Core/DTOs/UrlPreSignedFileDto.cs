﻿namespace SafeFileUploaderWeb.Core.DTOs;

public record UrlPreSignedFileDto(
    string OriginalFileName, string UniqueFileName, string Url);
