version=1.0.0

generate:
	$(MAKE) -C ./modules/go-client-generator/ generate-csharp-client service=order version=${version}
