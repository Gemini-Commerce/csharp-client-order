SHELL := /bin/bash

CUR_UID := $(shell id -u)
CUR_GID := $(shell id -g)

mkfile_path := $(abspath $(lastword $(MAKEFILE_LIST)))
current_dir := $(dir $(mkfile_path))
openapi_generator = docker run --rm --user ${CUR_GID}:${CUR_UID} -v ${current_dir}/:/csharp-client-generator -v ${PWD}/:/csharp-client-${lower_service} openapitools/openapi-generator-cli:v7.2.0
lower_service = $(shell echo $(service) | sed -e 's/\(.*\)/\L\1/')
ucf_service = $(shell echo $(service) | sed -e "s/\b\(.\)/\u\1/g")
artifact_version = $(shell if [ ! -z "${version}" ]; then echo "artifactVersion=${version},"; fi)

generate-csharp-client:
	[ ! -z "${service}" ] || (printf "\e[31mError: this command is meant to be execute from specific service client repo\e[0m\n"; exit 1) && \
	${openapi_generator} \
	generate -i csharp-client-generator/modules/proto/${lower_service}/${lower_service}.swagger.json \
	--git-repo-id csharp-client-${service} --git-user-id gemini-commerce --git-host github.com \
	-g csharp -t csharp-client-generator/templates/csharp -o csharp-client-${lower_service} \
	--git-host=github.com \
    --git-user-id=gemini-commerce \
    --git-repo-id=csharp-client-${lower_service} \
    --skip-validate-spec \
	--additional-properties ${artifact_version},enumClassPrefix=true,structPrefix=true,\
	packageName="${lower_service}"
