// See https://aka.ms/new-console-template for more information
using MetadataExtractor;

IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(Path.GetFullPath(args[0]));
foreach (var directory in directories)
    foreach (var tag in directory.Tags)
        Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");